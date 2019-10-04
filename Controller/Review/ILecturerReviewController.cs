using Advisor.View;

namespace Advisor.Controller
{
    public interface ILecturerReviewController
    {
        LecturerReviewView LecturerReviewView { get; set; }
        void HandleReviewSubmit();
    }
}
