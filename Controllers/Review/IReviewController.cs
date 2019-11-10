using Advisor.Models;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public interface IReviewController
    {
        ActionResult Index();
        ActionResult ReviewStudyProgram(Review review, int? program);
        ActionResult ReviewCourse(Review review, int? course);
        ActionResult ReviewLecturer(Review review, int? lecturer);
    }
}
