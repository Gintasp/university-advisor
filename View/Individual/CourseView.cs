using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class CourseView : Form
    {
        public ICourseController CourseController { get; set; }
        public ListBox ReviewList { get; set; }
        public Course Course { get; set; }
        public StatsData StatsData { get; set; }
        
        public CourseView(ICourseController courseController, Course course)
        {
            CourseController = courseController;
            Course = course;
            courseController.CourseView = this;
            InitializeComponent();
            ReviewList = Reviews;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            CourseController.LoadCourseData();
            CourseTitle.Text = Course.Title;
            ShowStatsData();
        }

        private void ShowStatsData()
        {
            UsefulnessVal.Text = StatsData.Usefulness.ToString() + " / 10";
            DifficultyVal.Text = StatsData.Difficulty.ToString() + " / 10";
            SatisfactionVal.Text = StatsData.Satisfaction.ToString() + " / 10";
            OveralVal.Text = StatsData.OveralRating.ToString() + " / 10";
            TheoryVal.Text = StatsData.Theory.ToString() + " %";
            PracticeVal.Text = StatsData.Practice.ToString() + " %";
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseController.HandlePreviousClicked();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LeaveReviewButton_Click(object sender, EventArgs e)
        {
            CourseController.HandleLeaveReviewClick();
        }
    }
}
