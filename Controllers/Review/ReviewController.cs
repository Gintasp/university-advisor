using Advisor.Models;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

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
        [Route("review")]
        public ActionResult Index(Review review, int university)
        {
            return View("/Views/Review/Review.cshtml");
        }
    }
}
