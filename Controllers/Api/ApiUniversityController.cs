using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Newtonsoft.Json;
using Advisor.Models.JSON;
using Advisor.Http.Response;

namespace Advisor.Controllers.Api
{
    public class ApiUniversityController : Controller, IApiUniversityController
    {
        public ApiUniversityController()
        {
        }

        [HttpGet]
        [Route("api/universities")]
        public string Universities()
        {
            var unis = DB.Instance.Universities.Select(u => new { u.Id, u.Title }).ToList();

            return JsonConvert.SerializeObject(unis, Formatting.Indented);
        }

        [HttpGet]
        [Route("university/{id:int}/programs", Name = "api_university_programs")]
        public string StudyPrograms(int id)
        {
            var programs = DB.Instance.StudyPrograms
                .Where(p => p.Faculty.University.Id == id)
                .Select(p => new { Id = p.Id, Title = p.Title })
                .ToList();

            return JsonConvert.SerializeObject(programs, Formatting.Indented);
        }

        [HttpGet]
        [Route("university/{id:int}/lecturers", Name = "api_university_lecturers")]
        public string Lecturers(int id)
        {
            var lecturers = DB.Instance.Lecturers
                .Where(l => l.Faculty.University.Id == id)
                .Select(l => new { Id = l.Id, Title = l.Name })
                .ToList();

            return JsonConvert.SerializeObject(lecturers, Formatting.Indented);
        }

        [HttpPost]
        [Route("api/universities/edit")]
        public string UniversityEdit(BasicModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            var uni = DB.Instance.Universities.Where(u => u.Id == data.Id).SingleOrDefault();
            uni.Title = data.Title;
            DB.Instance.SaveChanges();

            return Universities();
        }
    }
}
