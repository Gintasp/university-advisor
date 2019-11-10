using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Newtonsoft.Json;

namespace Advisor.Controllers.Api
{
    public class ApiStudyProgramController : Controller, IApiStudyProgramController
    {
        public ApiStudyProgramController()
        {
        }

        [HttpGet]
        [Route("program/{id:int}/courses", Name = "api_program_courses")]
        public string Index(int id)
        {
            var courses = DB.Instance.Courses
                .Where(c => c.StudyProgram.Id == id)
                .Select(c => new { Id = c.Id, Title = c.Title })
                .ToList();

            return JsonConvert.SerializeObject(courses, Formatting.Indented);
        }
    }
}
