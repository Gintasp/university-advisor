using Advisor.Models;
using Advisor.Services.Statistics;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Advisor.Controllers
{
    public class UniversityController : Controller, IUniversityController
    {
        public IStatsBuilder StatsBuilder { get; set; }

        public UniversityController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }

        [Route("universities/{id?}", Name = "universities_page")]
        public ActionResult Individual(int? id)
        {
            University uni = DB.Instance.Universities.Where(u => u.Id == id).SingleOrDefault(); 
            if (uni == null)
            { 
                return View("/Views/Shared/404.cshtml");

            }

            ViewBag.University = uni; 
            ViewBag.StatsData = LoadStats(uni);

            return View("/Views/Advisor/University.cshtml");
        }

        [Route("universities", Name = "universities_list")]
        public ActionResult Index()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;

            return View("/Views/Advisor/UniversityList.cshtml");
        }

        private StatsData LoadStats(University uni)
        {
            var stats = StatsBuilder.BuildUniversityStats(uni);
            StatsData statsData = new StatsData
            {
                OveralRating = stats.overal,
                FacultyCount = stats.faculty_count,
                StudyProgramCount = stats.study_program_count,
                Satisfaction = stats.satisfaction,
                AverageSalary = stats.salary,
                RelevantIndustryPercentage = stats.relevant_industry,
                DormitoryCount = stats.dormitory_count
            };

            return statsData;
        }
    }
}
