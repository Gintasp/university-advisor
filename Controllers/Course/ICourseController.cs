using System.Web;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public interface ICourseController
    {
        ActionResult Index(int? id);
        ActionResult UploadFile(HttpPostedFileBase file, int course);
    }
}
