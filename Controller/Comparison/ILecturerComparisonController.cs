using Advisor.Model;
using Advisor.View.Comparison;

namespace Advisor.Controller
{
    public interface ILecturerComparisonController
    {
        LecturerComparisonView LecturerComparisonView { get; set; }
        void HandleLecturerOneChooseClick();
        void HandleLecturerTwoChooseClick();
        void HandlePreviousButtonClick(Lecturer lec);
    }
}
