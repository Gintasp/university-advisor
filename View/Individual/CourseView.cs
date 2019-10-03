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
        
        public CourseView(ICourseController courseController, Course course)
        {
            CourseController = courseController;
            Course = course;
            CourseController.CourseView = this;
            InitializeComponent();
            ReviewList = Reviews;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            CourseController.LoadCourseReviews();
            CourseTitle.Text = Course.Title;
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
