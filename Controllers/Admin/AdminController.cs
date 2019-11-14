using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class AdminController: Controller
    {
        [Route("admin", Name = "admin_page")]
        public ActionResult Index()
        {

            return View("/Views/Admin/Admin.cshtml");
        }

    }
}