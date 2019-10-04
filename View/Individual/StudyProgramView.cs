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
        public ListBox ReviewList { get; set; }
        public ListBox CourseList { get; set; }
        public StudyProgramView(IStudyProgramController studyProgramController)
        {
            StudyProgramController = studyProgramController;
            studyProgramController.StudyProgramView = this;
            InitializeComponent();
            ReviewList = ReviewData;
            CourseList = CourseData;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            StudyProgramController.LoadStudyProgramData();
            TitleLabel.Text = StudyProgram.Title;
            AboutSection.Text = StudyProgram.Description;
        }

        private void OnLeaveReviewButtonClick(object sender, EventArgs e)
        {
            StudyProgramController.HandleLeaveReviewClick();
        }

        private void OnPreviousFormButtonClick(object sender, EventArgs e)
        {
            StudyProgramController.HandlePreviousButtonClick();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnCourseSelect(object sender, EventArgs e)
        {
            Course course = (Course) CourseData.SelectedItem;
            if (course != null)
            {
                StudyProgramController.HandleCourseSelect(course);
            }
        }

        private void OnAddCourseLinkClick(object sender, EventArgs e)
        {
            StudyProgramController.HandleAddCourseLinkClick();
        }
    }
}
