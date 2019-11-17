using System.Web.Mvc;

namespace Advisor.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public AdminController()
        {
        }

        [HttpGet]
        [Route("admin", Name = "admin_page")]
        public ActionResult Index()
        {
            return View("/Views/Admin/Admin.cshtml");
        }
    }
}
