using Advisor.Http.Response;
using Advisor.Models;
using Advisor.Services.Statistics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class ApiController : Controller
    {
        public IStatsBuilder StatsBuilder { get; set; }

        public ApiController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }

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
            try
            {
                var stats = StatsBuilder.BuildUniversityStats(uni);

                return JsonConvert.SerializeObject(stats, Formatting.Indented);
            }
            catch (Exception e)
            {
                return JsonConvert.SerializeObject(
                    new CustomResponse("Not found.", 404), Formatting.Indented
                );
            }
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
            var stats = StatsBuilder.BuildFacultyStats(faculty);

            return JsonConvert.SerializeObject(stats, Formatting.Indented);
        }

        [HttpGet]
        [Route("api/stats/program/{id}")]
        public string StudyProgramStats(int id)
        {
            StudyProgram program = DB.Instance.StudyPrograms.Where(p => p.Id == id).SingleOrDefault();
            if (program == null)
            {
                return JsonConvert.SerializeObject(
                    new CustomResponse("Not found.", 404), Formatting.Indented
                );
            }
            var stats = StatsBuilder.BuildStudyProgramStats(program);

            return JsonConvert.SerializeObject(stats, Formatting.Indented);
        }

        [HttpGet]
        [Route("api/stats/course/{id}")]
        public string CourseStats(int id)
        {
            Course course = DB.Instance.Courses.Where(c => c.Id == id).SingleOrDefault();
            if (course == null)
            {
                return JsonConvert.SerializeObject(
                    new CustomResponse("Not found.", 404), Formatting.Indented
                );
            }
            var stats = StatsBuilder.BuildCourseStats(course);

            return JsonConvert.SerializeObject(stats, Formatting.Indented);
        }

        [HttpGet]
        [Route("api/stats/lecturer/{id}")]
        public string LecturerStats(int id)
        {
            Lecturer lecturer = DB.Instance.Lecturers.Where(l => l.Id == id).SingleOrDefault();
            if (lecturer == null)
            {
                return JsonConvert.SerializeObject(
                    new CustomResponse("Not found.", 404), Formatting.Indented
                );
            }
            var stats = StatsBuilder.BuildLecturerStats(lecturer);

            return JsonConvert.SerializeObject(stats, Formatting.Indented);
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
