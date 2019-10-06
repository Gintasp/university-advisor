using Advisor.View;

namespace Advisor.Controller
{
    public interface ILecturerReviewController : IReviewController
    {
        LecturerReviewView LecturerReviewView { get; set; }
    }
}
