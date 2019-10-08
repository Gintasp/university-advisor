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
            ComparisonController.HandleProgramSelectClick();
        }
    }
}
