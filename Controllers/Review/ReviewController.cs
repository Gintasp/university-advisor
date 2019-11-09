using Advisor.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class ReviewController : Controller, IReviewController
    {
        public ReviewController()
        {
        }

        [HttpGet]
        [Route("review", Name = "review_page")]
        public ActionResult Index()
        {
            ViewBag.Universities = DB.Instance.Universities.ToList();
            ViewBag.StudyPrograms = DB.Instance.StudyPrograms.ToList();
            ViewBag.Courses = DB.Instance.Courses.ToList();

            return View("/Views/Review/Review.cshtml");
        }

        [HttpPost]
        [Route("review/program", Name = "review_program")]
        public ActionResult ReviewStudyProgram(Review review, int? program)
        {
            try
            {
                DB.Instance.StudyPrograms.Where(p => p.Id == program).SingleOrDefault().Reviews.Add(review);
                DB.Instance.SaveChanges();

                return RedirectToRoute("review_page");
            }
            catch (Exception e)
            {
                return View("/Views/Shared/Error.cshtml");
            }
        }

        [HttpPost]
        [Route("review/course", Name = "review_course")]
        public ActionResult ReviewCourse(Review review, int? course)
        {
            try
            {
                review.PracticePercentage = 100 - review.TheoryPercentage;
                DB.Instance.Courses.Where(c => c.Id == course).SingleOrDefault().Reviews.Add(review);
                DB.Instance.SaveChanges();

                return RedirectToRoute("review_page");
            }
            catch (Exception e)
            {
                return View("/Views/Shared/Error.cshtml");
            }
        }
    }
}
