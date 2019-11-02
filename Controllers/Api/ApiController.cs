using Advisor.Http.Response;
using Advisor.Models;
using Advisor.Service.Statistics;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("api/items")]
        public string Index()
        {
            string json = JsonConvert.SerializeObject(GetAllItems(), Formatting.Indented);

            return json;
        }

        [HttpGet]
        [Route("api/stats/university/{id}")]
        public string UniversityStats(int id)
        {
            University uni = DB.Instance.Universities.Where(u => u.Id == id).SingleOrDefault();
            if (uni == null)
            {
                return JsonConvert.SerializeObject(
                    new CustomResponse("Not found.", 404), Formatting.Indented
                );
            }
            var stats = CalculateUniversityStats(uni);

            return JsonConvert.SerializeObject(stats, Formatting.Indented);
        }

        [HttpGet]
        [Route("api/stats/faculty/{id}")]
        public string FacultyStats(int id)
        {
            Faculty faculty = DB.Instance.Faculties.Where(f => f.Id == id).SingleOrDefault();
            if (faculty == null)
            {
                return JsonConvert.SerializeObject(
                    new CustomResponse("Not found.", 404), Formatting.Indented
                );
            }
            var stats = CalculateFacultyStats(faculty);

            return JsonConvert.SerializeObject(stats, Formatting.Indented);
        }

        private dynamic CalculateFacultyStats(Faculty faculty)
        {
            List<Review> reviews = (from r in DB.Instance.Reviews
                                    join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                    join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                    where f.Id == faculty.Id
                                    select r).ToList();
            StatisticCalculator calc = new StatisticCalculator();
            var response = new
            {
                review_count = reviews.Count,
                overal = calc.CalcReviewAverage(reviews, r => r.OveralRating, 1),
                satisfaction = calc.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                salary = calc.CalcReviewAverage(reviews, r => r.Salary, 1),
                lecturer_count = faculty.Lecturers.Count,
                study_program_count = faculty.StudyPrograms.Count,
                relevant_industry = reviews.Count > 0 ? reviews.Count(r => r.RelevantIndustry == true) * 100 / reviews.Count : 0
            };

            return response;
        }

        private dynamic CalculateUniversityStats(University uni)
        {
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> reviews = (from r in DB.Instance.Reviews
                                    join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                    join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                    join u in DB.Instance.Universities on f.University.Id equals u.Id
                                    where u.Id == uni.Id
                                    select r).ToList();
            List<Faculty> faculties = uni.Faculties.ToList();
            int programCount = 0;
            faculties.ForEach(f => programCount += f.StudyPrograms.Count);
            var response = new
            {
                salary = calculator.CalcReviewAverage(reviews, r => r.Salary, 2),
                overal = calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1),
                satisfaction = calculator.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                faculty_count = uni.Faculties.Count,
                review_count = reviews.Count,
                study_program_count = programCount,
                relevant_industry = reviews.Count > 0 ? reviews.Count(r => r.RelevantIndustry == true) * 100 / reviews.Count : 0
            };

            return response;
        }

        private List<object> GetAllItems()
        {
            var unis = DB.Instance.Universities.Select(u =>
                new { u.Id, u.Title, Type = "University" }
            );
            var faculties = DB.Instance.Faculties.Select(f =>
                new { f.Id, f.Title, University = f.University.Title, Type = "Faculty" }
            );
            var programs = DB.Instance.StudyPrograms.Select(p =>
                new { p.Id, p.Title, University = p.Faculty.University.Title, Type = "Study program" }
            );
            var courses = DB.Instance.Courses.Select(c =>
                new { c.Id, c.Title, University = c.StudyProgram.Faculty.University.Title, Type = "Course" }
            );
            var lecturers = DB.Instance.Lecturers.Select(l =>
                new { l.Id, Title = l.Name, University = l.Faculty.University.Title, Type = "Lecturer" }
            );
            List<object> items = new List<object>();
            items.AddRange(unis);
            items.AddRange(faculties);
            items.AddRange(programs);
            items.AddRange(courses);
            items.AddRange(lecturers);

            return items;
        }
    }
}
