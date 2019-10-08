using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View.Comparison
{
    public partial class UniversityComparisonView : Form
    {
        public IUniversityComparisonController UniversityComparisonController { get; set; }
        public University University { get; set; }
        public UniversityComparisonView(IUniversityComparisonController universityComparisonController, University uni)
        {
            UniversityComparisonController = universityComparisonController;
            University = uni;
            universityComparisonController.UniversityComparisonView = this;
            InitializeComponent();
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UniversityComparisonController.HandlePreviousButtonClick(University);
        }
    }
}
