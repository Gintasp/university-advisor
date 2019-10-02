using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class StudySubjectView : Form
    {
        public IStudySubjectController StudySubjectController { get; set; }
        
        public StudySubjectView(IStudySubjectController studySubjectController)
        {
            StudySubjectController = studySubjectController;
            StudySubjectController.StudySubjectView = this;
            InitializeComponent();
        }
        private void OnViewLoad(object sender, EventArgs e)
        {
            StudySubjectController.LoadReviews(Reviews);
        }
        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudySubjectController.HandlePreviousClicked();
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
