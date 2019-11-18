using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Newtonsoft.Json;
using Advisor.Models.JSON;
using Advisor.Http.Response;

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

        [HttpPost]
        [Route("api/courses/edit")]
        public string CourseEdit(BasicModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            var course = DB.Instance.Courses.Where(c => c.Id == data.Id).SingleOrDefault();
            course.Title = data.Title;
            DB.Instance.SaveChanges();

            return Courses();
        }
    }
}
