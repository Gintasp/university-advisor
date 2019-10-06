using Advisor.Controller;
using System;
using System.Windows.Forms;

namespace Advisor.View.Comparison
{
    public partial class CourseComparisonView : Form
    {
        public ICourseController CourseController { get; set; }
        
        public CourseComparisonView(CourseController courseController)
        {
            CourseController = courseController;
            InitializeComponent();
        }

        private void OnCourseSelectClick(object sender, EventArgs e)
        {
            CourseController.DisplayPopup();
        }
    }
}
