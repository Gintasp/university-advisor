using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Newtonsoft.Json;
using Advisor.Http.Response;
using Advisor.Models.JSON;

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

        [HttpGet]
        [Route("api/programs")]
        public string Programs()
        {
            var programs = DB.Instance.StudyPrograms
                .Select(p => new { p.Id, p.Title, UniversityId = p.Faculty.University.Id, FacultyId = p.Faculty.Id })
                .ToList();

            return JsonConvert.SerializeObject(programs, Formatting.Indented);
        }

        [HttpGet]
        [Route("api/programs/uni/{id:int}")]
        public string ProgramsByUni(int id)
        {
            var programs = DB.Instance.StudyPrograms
                .Select(p => new { p.Id, p.Title, UniversityId = p.Faculty.University.Id, FacultyId = p.Faculty.Id })
                .Where(p => p.UniversityId == id)
                .ToList();

            return JsonConvert.SerializeObject(programs, Formatting.Indented);
        }

        [HttpPost]
        [Route("api/programs/edit")]
        public string ProgramEdit(BasicModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            var program = DB.Instance.StudyPrograms.Where(p => p.Id == data.Id).SingleOrDefault();
            program.Title = data.Title;
            DB.Instance.SaveChanges();

            return Programs();
        }

        [HttpPost]
        [Route("api/programs/add")]
        public string ProgramAdd(StudyProgramDataModel data)
        {
            if (data == null || data.Id == null)
            {
                return JsonConvert.SerializeObject(new CustomResponse("Bad request.", 400));
            }
            StudyProgram program = new StudyProgram
            {
                Title = data.Title
            };
            program.Faculty = DB.Instance.Faculties.Where(u => u.Id == data.FacultyId).SingleOrDefault();
            DB.Instance.StudyPrograms.Add(program);
            DB.Instance.SaveChanges();

            return Programs();
        }
    }
}
