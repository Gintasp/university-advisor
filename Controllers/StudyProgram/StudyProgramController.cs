using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Advisor.Services.Statistics;

namespace Advisor.Controllers
{
    public class StudyProgramController : Controller, IStudyProgramController
    {

        private delegate StatsData Delegate(StudyProgram program);
        private event Delegate MyEvent;
        public IStatsBuilder StatsBuilder { get; set; }

        public StudyProgramController()
        {
        }

        public StudyProgramController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }

        [Route("programs/{id?}", Name = "program_page")]
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                StudyProgram studyProgram = DB.Instance.StudyPrograms.Where(s => s.Id == id).SingleOrDefault();
                if (studyProgram == null)
                {
                    return View("/Views/Shared/404.cshtml");
                }

                ViewBag.StudyProgram = studyProgram;
                MyEvent += new Delegate(LoadStats);
                ViewBag.StatsData = MyEvent(studyProgram);

                return View("/Views/Advisor/StudyProgram.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }

        private StatsData LoadStats(StudyProgram studyProgram)
        {
            var stats = StatsBuilder.BuildStudyProgramStats(studyProgram);
            StatsData statsData = new StatsData
            {
                ReviewCount = stats.review_count,
                OveralRating = stats.overal,
                Satisfaction = stats.satisfaction,
                AverageSalary = stats.salary,
                CourseCount = stats.course_count,
                RelevantIndustryPercentage = stats.relevant_industry
            };

            return statsData;
        }
    }
}
