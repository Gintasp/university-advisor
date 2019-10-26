using Advisor.Model;

namespace Advisor.Controllers
{
    public interface IFacultyController
    {
        void HandlePreviousButtonClick(University uni);
        void LoadData();
        void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni);
        void HandleLecturerSelect(Lecturer lecturer);
        void HandleAddStudyProgramClick();
        void HandleAddLecturerClick();
        void HandleCompareLink();
    }
}