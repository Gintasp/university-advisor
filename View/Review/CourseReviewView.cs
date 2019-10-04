using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class CourseReviewView : Form
    {
        public ICourseReviewController CourseReviewController { get; set; }
        public CourseReviewView(ICourseReviewController courseReviewController)
        {
            CourseReviewController = courseReviewController;
            courseReviewController.CourseReviewView = this;
            InitializeComponent();
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            CourseReviewController.HandleSubmitReviewButtonClick();
        }
    }
}
