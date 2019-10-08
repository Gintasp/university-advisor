using Advisor.Controller;
using Advisor.Model;
using System;
using System.Windows.Forms;

namespace Advisor.View.Comparison
{
    public partial class CourseComparisonView : Form
    {
        public ICourseComparisonController CourseComparisonController { get; set; }

        public CourseComparisonView(ICourseComparisonController comparisonController)
        {
            CourseComparisonController = comparisonController;
            comparisonController.CourseComparisonView = this;
            InitializeComponent();
        }

        public void LoadCourseOne(Course course, StatsData statsData)
        {
            ReviewCountCourse1.Text = statsData.ReviewCount.ToString();
            CourseTitle1.Text = course.Title;
            RatingCourse1.Text = statsData.OveralRating.ToString();
            LevelOfSatisfactionCourse1.Text = statsData.Satisfaction.ToString();
            DifficultyCourse1.Text = statsData.Difficulty.ToString();
            UsefulnessCourse1.Text = statsData.Usefulness.ToString();
            InterestingCourse1.Text = statsData.Interesting.ToString();
            TheoryCourse1.Text = statsData.Theory.ToString();
            PracticeCourse1.Text = statsData.Practice.ToString();
        }

        public void LoadCourseTwo(Course course, StatsData statsData)
        {
            ReviewCountCourse2.Text = statsData.ReviewCount.ToString();
            CourseTitle2.Text = course.Title;
            RatingCourse2.Text = statsData.OveralRating.ToString();
            LevelOfSatisfactionCourse2.Text = statsData.Satisfaction.ToString();
            DifficultyCourse2.Text = statsData.Difficulty.ToString();
            UsefulnessCourse2.Text = statsData.Usefulness.ToString();
            InterestingCourse2.Text = statsData.Interesting.ToString();
            TheoryCourse2.Text = statsData.Theory.ToString();
            PracticeCourse2.Text = statsData.Practice.ToString();
        }

        private void OnCourseOneSelectClick(object sender, EventArgs e)
        {
            CourseComparisonController.HandleCourseOneSelectClick();
        }

        private void OnCourseTwoSelectClick(object sender, EventArgs e)
        {
            CourseComparisonController.HandleCourseTwoSelectClick();
        }
    }
}
