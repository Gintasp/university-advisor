using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IFacultyController
    {
        FacultyView FacultyView { get; set; }
        StudyProgramView StudyProgramView { get; set; }
        void HandlePreviousButtonClick(University uni);
        void LoadData(Faculty faculty);
        void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni);
        void HandleLecturerSelect(Lecturer lecturer, Faculty faculty, University university);
        void HandleAddStudyProgramClick();
    }
}