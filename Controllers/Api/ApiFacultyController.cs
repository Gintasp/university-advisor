using Advisor.Models;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Linq;
using Advisor.Models.JSON;
using Advisor.Http.Response;

namespace Advisor.Controllers.Api
{
    public class ApiFacultyController : Controller
    {
        public ApiFacultyController()
        {
        }

        [HttpGet]
        [Route("api/faculties/{id:int}")]
        public string FacultyByUniId(int id)
        {
            var faculties = DB.Instance.Faculties
                .Select(f => new { f.Id, f.Title, UniversityId = f.University.Id })
                .Where(f => f.UniversityId == id)
                .ToList();

            return JsonConvert.SerializeObject(faculties, Formatting.Indented);
        }

        [HttpGet]
        [Route("api/faculties")]
        public string Faculties()
        {
            var faculties = DB.Instance.Faculties.Select(f => new { f.Id, f.Title, UniversityId = f.University.Id }).ToList();
            
            return JsonConvert.SerializeObject(faculties, Formatting.Indented);
        }

        [HttpPost]
        [Route("api/faculties/edit")]
        public string FacultyEdit(BasicModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            var faculty = DB.Instance.Faculties.Where(f => f.Id == data.Id).SingleOrDefault();
            faculty.Title = data.Title;
            DB.Instance.SaveChanges();

            return Faculties();
        }

        [HttpPost]
        [Route("api/faculties/add")]
        public string FacultyAdd(FacultyDataModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            Faculty faculty = new Faculty
            {
                Title = data.Title
            };
            faculty.University = DB.Instance.Universities.Where(u => u.Id == data.UniversityId).SingleOrDefault();
            DB.Instance.Faculties.Add(faculty);
            DB.Instance.SaveChanges();

            return Faculties();
        }
    }
}
