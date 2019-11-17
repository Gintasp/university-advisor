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
            if (!User.IsInRole("User"))
            {
                return RedirectToRoute("login");
            }

            ViewBag.Universities = DB.Instance.Universities.ToList();
            ViewBag.StudyPrograms = DB.Instance.StudyPrograms.ToList();
            ViewBag.Courses = DB.Instance.Courses.ToList();
            ViewBag.Lecturers = DB.Instance.Lecturers.ToList();

            return View("/Views/Review/Review.cshtml");
        }

        [HttpPost]
        [Route("review/program", Name = "review_program")]
        public ActionResult ReviewStudyProgram(Review review, int? program)
        {
            if (!User.IsInRole("User"))
            {
                return RedirectToRoute("login");
            }

            review.User = GetCurrentUser();
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
            if (!User.IsInRole("User"))
            {
                return RedirectToRoute("login");
            }

            review.User = GetCurrentUser();
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

        [HttpPost]
        [Route("review/lecturer", Name = "review_lecturer")]
        public ActionResult ReviewLecturer(Review review, int? lecturer)
        {
            if (!User.IsInRole("User"))
            {
                return RedirectToRoute("login");
            }

            review.User = GetCurrentUser();
            try
            {
                DB.Instance.Lecturers.Where(l => l.Id == lecturer).SingleOrDefault().Reviews.Add(review);
                DB.Instance.SaveChanges();

                return RedirectToRoute("review_page");
            }
            catch (Exception e)
            {
                return View("/Views/Shared/Error.cshtml");
            }
        }

        private User GetCurrentUser()
        {
            try
            {
                return DB.Instance.Users.Where(u => u.Email == User.Identity.Name).SingleOrDefault();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
