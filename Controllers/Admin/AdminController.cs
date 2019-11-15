using Advisor.Models;
using Advisor.Services.Statistics;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Advisor.Controllers
{
    public class AdminController: Controller
    {
        [Route("admin", Name = "admin_page")]
        public ActionResult Index()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;
            return View("/Views/Admin/Admin.cshtml");
        }

    }
}