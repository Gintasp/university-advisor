using Advisor.Controller;
using System;
using System.Windows.Forms;

namespace Advisor.View.Comparison
{
    public partial class CourseComparisonView : Form
    {
        public ICourseComparisonController CourseComparisonController { get; set; }

        public CourseComparisonView(ICourseComparisonController comparisonController)
        {
            CourseComparisonController = comparisonController;
            InitializeComponent();
        }

        private void OnCourseSelectClick(object sender, EventArgs e)
        {
            //TODO: Handle displaying popup
        }
    }
}
