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
            //ReviewCountCourse1.Text = statsData.ReviewCount.ToString();
            CourseTitle1.Text = course.Title;
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
