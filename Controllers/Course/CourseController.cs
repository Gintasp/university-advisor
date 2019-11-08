using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Advisor.Services.Statistics;

namespace Advisor.Controllers
{
    public class CourseController : Controller, ICourseController
    {
        public IStatsBuilder StatsBuilder { get; set; }
        public CourseController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }

        [Route("courses/{id?}", Name = "course_page")]
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                Course course = DB.Instance.Courses.Where(s => s.Id == id).SingleOrDefault();
                if (course == null)
                {
                    return View("/Views/Shared/404.cshtml");
                }

                ViewBag.Course = course;
                ViewBag.StatsData = GetCourseStats(course);

                return View("/Views/Course/Course.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }
        private StatsData GetCourseStats(Course course)
        {
            var stats = StatsBuilder.BuildCourseStats(course);
            StatsData statsData = new StatsData
            {
                ReviewCount = stats.review_count,
                Satisfaction = stats.satisfaction,
                Difficulty = stats.difficulty,
                Usefulness = stats.usefulness,
                Interesting = stats.interesting,
                Theory = stats.theory,
                Practice = stats.practice,
                OveralRating = stats.overal
            };

            return statsData;
        }
    }
}
