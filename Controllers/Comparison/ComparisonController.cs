using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class ComparisonController : Controller, IComparisonController
    {
        public ComparisonController()
        {
        }

        [Route("compare", Name = "compare")]
        public ActionResult Show()
        {
            return View("/Views/Comparison/Comparison.cshtml");
        }
    }
}
