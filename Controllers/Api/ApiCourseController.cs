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
            using (DatabaseContext context = new DatabaseContext())
            {
                var courses = context.Courses
                .Select(c => new
                {
                    c.Id,
                    c.Title,
                    FacultyId = c.StudyProgram.Faculty.Id,
                    UniversityId = c.StudyProgram.Faculty.University.Id
                })
                .ToList();

                return JsonConvert.SerializeObject(courses, Formatting.Indented);
            }
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

        [HttpPost]
        [Route("api/courses/add")]
        public string CourseAdd(BasicModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            var program = DB.Instance.StudyPrograms.Where(p => p.Id == data.Id).SingleOrDefault();
            program.Courses.Add(new Course { Title = data.Title });
            DB.Instance.SaveChanges();

            return Courses();
        }

        [HttpGet]
        [Route("api/courses/faculty/{id:int}")]
        public string CoursesByFaculty(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var courses = context.Courses
                .Select(c => new
                {
                    c.Id,
                    c.Title,
                    FacultyId = c.StudyProgram.Faculty.Id,
                    UniversityId = c.StudyProgram.Faculty.University.Id
                })
                .Where(c => c.FacultyId == id)
                .ToList();

                return JsonConvert.SerializeObject(courses, Formatting.Indented);
            }
        }
    }
}
