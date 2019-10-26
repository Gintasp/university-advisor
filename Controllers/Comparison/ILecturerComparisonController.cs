using Advisor.Models;

namespace Advisor.Controllers
{
    public interface ILecturerComparisonController
    {
        void HandleLecturerOneChooseClick();
        void HandleLecturerTwoChooseClick();
        void HandlePreviousButtonClick(Lecturer lec);
    }
}
