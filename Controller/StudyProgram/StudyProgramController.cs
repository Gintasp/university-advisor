using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public class StudyProgramController : IStudyProgramController
    {
        public StudyProgramView StudyProgramView { get; set; }
        public StudyProgram StudyProgram { get; set; }

        public StudyProgramController(StudyProgram studyProgram)
        {
            StudyProgram = studyProgram;
        }

        public void LoadStudyProgramData(Label label)
        {
            label.Text = StudyProgram.Title;
        }
    }
}
