using Advisor.Models;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System;

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
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;

            return View("/Views/Admin/Admin.cshtml");
        }
    }
}
