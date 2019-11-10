using System.Web.Mvc;

namespace Advisor.Controllers
{
    public interface IStudyProgramController
    {
        ActionResult Index(int? id);
    }
}
