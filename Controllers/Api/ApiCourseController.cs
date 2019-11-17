using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Newtonsoft.Json;

namespace Advisor.Controllers.Api
{
    public class ApiCourseController : Controller
    {
        public ApiCourseController()
        {
        }

        [HttpGet]
        [Route("api/courses")]
        public string Courses()
        {
            var courses = DB.Instance.Courses
                .Select(c => new { c.Id, c.Title, FacultyId = c.StudyProgram.Faculty.Id })
                .ToList();

            return JsonConvert.SerializeObject(courses, Formatting.Indented);
        }
    }
}
