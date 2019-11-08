using Advisor.Models;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
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

        [Route("course/{id?}", Name = "course_page")]
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
                ViewBag.StatsData = LoadStats(course);

                return View("/Views/Course/Course.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }
        private StatsData LoadStats(Course course)
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

        //private void LoadStats()
        //{
            //StatsData statsData = new StatsData();
            //StatisticCalculator calculator = new StatisticCalculator();
            //List<Review> courseReviews = Course.Reviews.ToList();
            //statsData.Usefulness = calculator.CalcReviewAverage(courseReviews, r => r.Usefulness, 1);
            //statsData.Difficulty = calculator.CalcReviewAverage(courseReviews, r => r.Difficulty, 1);
            //statsData.Satisfaction = calculator.CalcReviewAverage(courseReviews, r => r.Satisfaction, 1);
            //statsData.OveralRating = calculator.CalcReviewAverage(courseReviews, r => r.OveralRating, 1);
            //statsData.Theory = calculator.CalcReviewAverage(courseReviews, r => r.TheoryPercentage, 1);
            //statsData.Practice = calculator.CalcReviewAverage(courseReviews, r => r.PracticePercentage, 1);

            //CourseView.StatsData = statsData;
        //}
    }
}
