using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Newtonsoft.Json;
using Advisor.Models.JSON;
using Advisor.Http.Response;

namespace Advisor.Controllers.Api
{
    public class ApiLecturerController : Controller
    {
        public ApiLecturerController()
        {
        }

        [HttpGet]
        [Route("api/lecturers")]
        public string Lecturers()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var lecturers = context.Lecturers
                .Select(l => new
                {
                    l.Id,
                    Title = l.Name,
                    FacultyId = l.Faculty.Id,
                    UniversityId = l.Faculty.University.Id
                })
                .ToList();

                return JsonConvert.SerializeObject(lecturers, Formatting.Indented);
            }
        }

        [HttpPost]
        [Route("api/lecturers/edit")]
        public string LecturerEdit(BasicModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            var lecturer = DB.Instance.Lecturers.Where(c => c.Id == data.Id).SingleOrDefault();
            lecturer.Name = data.Title;
            DB.Instance.SaveChanges();

            return Lecturers();
        }

        [HttpPost]
        [Route("api/lecturers/add")]
        public string LecturerAdd(LecturerDataModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            var course = DB.Instance.Courses.Where(c => c.Id == data.Id).SingleOrDefault();
            var faculty = DB.Instance.Faculties.Where(f => f.Id == data.FacultyId).SingleOrDefault();
            course.Lecturer = new Lecturer { Name = data.Title, Faculty = faculty };
            DB.Instance.SaveChanges();

            return Lecturers();
        }
    }
}
