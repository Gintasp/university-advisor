using Advisor.Models;
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
                new { l.Id, l.Name, University = l.Faculty.University.Title, Type = "Lecturer" }
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
