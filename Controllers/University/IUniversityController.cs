using System.Web.Mvc;

namespace Advisor.Controllers
{
    public interface IUniversityController
    {
        ActionResult Index(int? id);
    }
}
