using Advisor.View;
using Advisor.Model;

namespace Advisor.Controller
{
    class StudyProgramComparisonController : IStudyProgramComparisonController
    {
        public StudyProgramComparisonView ComparisonView { get; set; }
        public StudyProgram FirstStudyProgram { get; set; }
        public StudyProgram SecondStudyProgram { get; set; }

        public StudyProgramComparisonController(StudyProgram firstStudyProgram)
        {
            FirstStudyProgram = firstStudyProgram;
        }

        public void HandleProgramSelectClick()
        {
            
        }
    }
}
