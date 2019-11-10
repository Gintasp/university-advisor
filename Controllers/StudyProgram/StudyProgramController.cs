using Advisor.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Advisor.Services.Statistics;

namespace Advisor.Controllers
{
    public class StudyProgramController : Controller, IStudyProgramController
    {
        public IStatisticCalculator StatisticCalculator { get; set; }

        public StudyProgramController()
        {
        }

        public StudyProgramController(IStatisticCalculator statisticCalculator)
        {
            StatisticCalculator = statisticCalculator;
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
                ViewBag.StatsData = LoadStats(studyProgram);

                return View("/Views/StudyProgram/StudyProgram.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }

        private StatsData LoadStats(StudyProgram studyProgram)
        {
            StatsData statsData = new StatsData();
            List<Review> studyProgramReviews = (from r in DB.Instance.Reviews
                                                join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                                where p.Id == studyProgram.Id
                                                select r).ToList();
            statsData.OveralRating = StatisticCalculator.CalcReviewAverage(studyProgramReviews, r => r.OveralRating, 1);
            statsData.Satisfaction = StatisticCalculator.CalcReviewAverage(studyProgramReviews, r => r.Satisfaction, 1);
            statsData.AverageSalary = StatisticCalculator.CalcReviewAverage(studyProgramReviews, r => r.Salary, 1);
            statsData.ReviewCount = studyProgramReviews.Count;
            if (statsData.ReviewCount != 0)
            {
                statsData.RelevantIndustryPercentage = studyProgramReviews
                    .Count(r => r.RelevantIndustry == true) * 100 / statsData.ReviewCount;
            }

            return statsData;
        }
    }
}
