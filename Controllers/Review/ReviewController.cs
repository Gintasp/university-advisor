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

            return View("/Views/Review/Review.cshtml");
        }

        [HttpPost]
        [Route("review/program", Name = "review_program")]
        public ActionResult Index(Review review, int? program)
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
    }
}
