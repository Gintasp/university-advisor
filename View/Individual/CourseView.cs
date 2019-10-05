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
        public ReviewData ReviewData { get; set; }
        
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
            UsefulnessVal.Text = ReviewData.Usefulness.ToString() + " / 10";
            DifficultyVal.Text = ReviewData.Difficulty.ToString() + " / 10";
            SatisfactionVal.Text = ReviewData.Satisfaction.ToString() + " / 10";
            OveralVal.Text = ReviewData.OveralRating.ToString() + " / 10";
            TheoryVal.Text = ReviewData.Theory.ToString() + " %";
            PracticeVal.Text = ReviewData.Practice.ToString() + " %";
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseController.HandlePreviousClicked();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
