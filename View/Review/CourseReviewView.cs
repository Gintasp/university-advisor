using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class CourseReviewView : Form
    {
        public IReviewController ReviewController { get; set; }
        public CourseReviewView(IReviewController reviewController)
        {
            ReviewController = reviewController;
            reviewController.TextReviewView = this;
            InitializeComponent();
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            ReviewController.HandleSubmitReviewButtonClick();
        }

        private void OnPreviousFormLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReviewController.HandlePreviousFormLinkClick();
        }
    }
}
