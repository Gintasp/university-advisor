using Advisor.Models;
using Advisor.Services.Statistics;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;


namespace Advisor.Controllers
{
    public class RatingsController : Controller
    {
        // GET: Ratings
        [Route("ratings", Name = "ratings_page")]
        public ActionResult Index()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;

            return View("/Views/Advisor/Ratings/Ratings.cshtml");
        }
    }
}