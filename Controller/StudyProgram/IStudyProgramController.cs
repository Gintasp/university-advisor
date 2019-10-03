using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IStudyProgramController
    {
        StudyProgramView StudyProgramView { get; set; }
        void LoadStudyProgramData();
        void HandlePreviousButtonClick();
        void HandleCoursesButtonClick();
    }
}