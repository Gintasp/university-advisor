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
            StatsData stats = CalculateStats(uni);

            return JsonConvert.SerializeObject(stats, Formatting.Indented);
        }

        private StatsData CalculateStats(University uni)
        {
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> reviews = (from r in DB.Instance.Reviews
                                    join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                    join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                    join u in DB.Instance.Universities on f.University.Id equals u.Id
                                    where u.Id == uni.Id
                                    select r).ToList();
            StatsData statsData = new StatsData()
            {
                AverageSalary = calculator.CalcReviewAverage(reviews, r => r.Salary, 2),
                OveralRating = calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1),
                Satisfaction = calculator.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                FacultyCount = uni.Faculties.Count,
                ReviewCount = reviews.Count,
                StudyProgramCount = 0,
            };
            foreach (Faculty f in uni.Faculties)
            {
                statsData.StudyProgramCount += f.StudyPrograms.Count;
            }
            if (statsData.ReviewCount != 0)
            {
                statsData.RelevantIndustryPercentage = reviews.Count(r => r.RelevantIndustry == true) * 100 / statsData.ReviewCount;
            }

            return statsData;
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
