using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class RatingsController : Controller
    {
        // GET: Ratings
        [Route("ratings", Name = "ratings_page")]
        public ActionResult Index()
        {
            

            return View("/Views/Advisor/Ratings/Ratings.cshtml");
        }
    }
}