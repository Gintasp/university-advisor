using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class StudySubjectView : Form
    {
        public IStudySubjectController StudySubjectController { get; set; }
        public ListBox ReviewList { get; set; }
        public StudySubject StudySubject { get; set; }
        
        public StudySubjectView(IStudySubjectController studySubjectController, StudySubject subject)
        {
            StudySubjectController = studySubjectController;
            StudySubject = subject;
            StudySubjectController.StudySubjectView = this;
            InitializeComponent();
            ReviewList = Reviews;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            StudySubjectController.LoadSubjectReviews();
            SubjectTitle.Text = StudySubject.Title;
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
