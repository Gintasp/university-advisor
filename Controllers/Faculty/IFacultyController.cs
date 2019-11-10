using System.Web.Mvc;

namespace Advisor.Controllers
{
    public interface IFacultyController
    {
        ActionResult Index(int? id);
    }
}
