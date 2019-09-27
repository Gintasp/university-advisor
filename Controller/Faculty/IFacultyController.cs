using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IFacultyController
    {
        FacultyView FacultyView { get; set; }
        void HandlePreviousButtonClick(University uni);
    }
}