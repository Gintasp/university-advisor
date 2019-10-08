using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class StudyProgramComparisonView : Form
    {
        public IStudyProgramComparisonController ComparisonController { get; set; }
        public StudyProgramComparisonView(IStudyProgramComparisonController studyProgramComparisonController)
        {
            ComparisonController = studyProgramComparisonController;
            InitializeComponent();
        }

        private void OnSelectProgramClick(object sender, System.EventArgs e)
        {
            Button SenderButton = (Button)sender;
            bool isItSecondButton = false;

            if(SenderButton.Name == "StudyProgram2")
            {
                isItSecondButton = true;
            }

            ComparisonController.HandleProgramSelectClick(isItSecondButton);
        }
    }
}
