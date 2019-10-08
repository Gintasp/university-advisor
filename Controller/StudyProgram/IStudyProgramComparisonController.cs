using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IStudyProgramComparisonController
    {
        StudyProgramComparisonView ComparisonView { get; set; }
        StudyProgramSelectView SelectView { get; set; }
        StudyProgram FirstStudyProgram { get; set; }
        StudyProgram SecondStudyProgram { get; set; }
        bool SecondButtonClicked { get; set; }
        void HandleProgramSelectClick(bool wasSecondButtonClicked);
        void LoadUniversities();
        void LoadFaculties(University uni);
        void LoadStudyPrograms(Faculty fac);
        void SelectedStudyProgram(StudyProgram prog);
        void UpdateData();
    }
}
