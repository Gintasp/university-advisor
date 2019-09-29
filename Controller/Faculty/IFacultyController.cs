using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IFacultyController
    {
        FacultyView FacultyView { get; set; }
        StudyProgramView StudyProgramView { get; set; }
        void HandlePreviousButtonClick(University uni);
        void LoadStudyProgramData(ListBox listBox);
        void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni);
    }
}