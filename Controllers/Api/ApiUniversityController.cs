using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Newtonsoft.Json;

namespace Advisor.Controllers.Api
{
    public class ApiUniversityController : Controller
    {
        public ApiUniversityController()
        {
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
    }
}
