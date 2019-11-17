using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("", Name = "home")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("about", Name = "about_page")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        [Route("contact", Name = "contact_page")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
