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

        [Route("review", Name = "review_page")]
        public ActionResult Index()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;

            return View("/Views/Review/Review.cshtml");
        }
    }
}