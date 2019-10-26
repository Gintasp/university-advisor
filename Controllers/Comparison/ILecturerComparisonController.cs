using Advisor.Model;

namespace Advisor.Controllers
{
    public interface ILecturerComparisonController
    {
        void HandleLecturerOneChooseClick();
        void HandleLecturerTwoChooseClick();
        void HandlePreviousButtonClick(Lecturer lec);
    }
}
