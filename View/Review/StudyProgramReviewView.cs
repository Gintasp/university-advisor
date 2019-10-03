using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class StudyProgramReviewView : Form
    {
        public IStudyProgramReviewController StudyProgramReviewController { get; set; }
        public StudyProgramReviewView(IStudyProgramReviewController studyProgramReviewController)
        {
            StudyProgramReviewController = studyProgramReviewController;
            studyProgramReviewController.StudyProgramReviewView = this;
            InitializeComponent();
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            StudyProgramReviewController.HandleSubmitReviewButtonClick();
        }
    }
}
