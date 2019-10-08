using Advisor.Model;

namespace Advisor.Controller
{
    public interface IStudyProgramComparisonController
    {
        void HandleProgramSelectClick(bool wasSecondButtonClicked);
        void LoadUniversities();
        void LoadFaculties(University uni);
        void LoadStudyPrograms(Faculty fac);
        void SelectedStudyProgram(StudyProgram prog);
        bool SecondButtonClicked { get; set; }
    }
}
