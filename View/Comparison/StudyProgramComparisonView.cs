using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class StudyProgramComparisonView : Form
    {
        public IStudyProgramComparisonController ComparisonController { get; set; }
        public StatsData FirstProgramData { get; set; }
        public StatsData SecondProgramData { get; set; }
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

        private void OnFormLoad(object sender, System.EventArgs e)
        {
            ComparisonController.UpdateData();
        }

        private void ShowStatsData(bool showFirst, bool showSecond)
        {
            
        }
    }
}
