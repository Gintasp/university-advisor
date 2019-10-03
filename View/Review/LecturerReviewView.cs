using Advisor.Controller;
using System;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class LecturerReviewView : Form
    {
        public ILecturerReviewController LecturerReviewController { get; set; }
        public LecturerReviewView(ILecturerReviewController lecturerReviewController)
        {
            LecturerReviewController = lecturerReviewController;
            LecturerReviewController.LecturerReviewView = this;
            InitializeComponent();
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            LecturerReviewController.HandleReviewSubmit();
        }
    }
}
