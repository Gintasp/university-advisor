using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Advisor.Services.Statistics;

namespace Advisor.Controllers
{
    public class FacultyController : Controller, IFacultyController
    {
        public IStatsBuilder StatsBuilder { get; set; }
        public FacultyController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }

        [Route("faculties/{id?}", Name = "faculty_page")]
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                Faculty faculty = DB.Instance.Faculties.Where(u => u.Id == id).SingleOrDefault();
                if (faculty == null)
                {
                    return View("/Views/Shared/404.cshtml");
                }

                ViewBag.Faculty = faculty;
                ViewBag.StatsData = LoadStats(faculty);
                ViewBag.Address = faculty.Addresses.ToList().ElementAt(0).ToString();

                return View("/Views/Faculty.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }

        private StatsData LoadStats(Faculty faculty)
        {
            var stats = StatsBuilder.BuildFacultyStats(faculty);
            StatsData statsData = new StatsData
            {
                ReviewCount = stats.review_count,
                OveralRating = stats.overal,
                StudyProgramCount = stats.study_program_count,
                Satisfaction = stats.satisfaction,
                AverageSalary = stats.salary,
                RelevantIndustryPercentage = stats.relevant_industry,
                LocationCount = stats.location_count,
                LecturerCount = stats.lecturer_count
            };

            return statsData;
        }
    }
}
