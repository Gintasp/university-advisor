using Advisor.Controller;
using Advisor.Model;
using System;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class StudyProgramView : Form
    {
        public IStudyProgramController StudyProgramController { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public ListBox ReviewListBox { get; set; }
        public StudyProgramView(IStudyProgramController studyProgramController)
        {
            StudyProgramController = studyProgramController;
            studyProgramController.StudyProgramView = this;
            InitializeComponent();
            ReviewListBox = ReviewList;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            StudyProgramController.LoadStudyProgramData();
            StudyProgramTitle.Text = StudyProgram.Title;
            AboutSection.Text = StudyProgram.Description;
        }

        private void OnLeaveReviewButtonClick(object sender, EventArgs e)
        {
            //TODO: Handle leave a review button click and display review form
        }

        private void OnStudySubjectsButtonClick(object sender, EventArgs e)
        {
            StudyProgramController.HandleStudySubjectsButtonClick();
        }

        private void OnPreviousFormButtonClick(object sender, EventArgs e)
        {
            StudyProgramController.HandlePreviousButtonClick();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
