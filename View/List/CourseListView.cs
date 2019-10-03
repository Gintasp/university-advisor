using Advisor.Controller;
using Advisor.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class CourseListView : Form
    {
        public ICourseListController CourseListController { get; set; }
        public ListBox CourseList { get; set; }
        public CourseListView(ICourseListController courseListController)
        {
            CourseListController = courseListController;
            CourseListController.CourseListView = this;
            InitializeComponent();
            CourseList = CourseData;
        }

        private void OnSearchInputEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void OnSearchInputLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void OnAddCourseButtonClick(object sender, EventArgs e)
        {
            //TODO: handle adding new study subject
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            CourseListController.LoadCourseData();
        }

        private void OnPreviousFormButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseListController.HandlePreviousFormButtonClick();
        }

        private void OnCourseSelect(object sender, EventArgs e)
        {
            Course subject = (Course) CourseData.SelectedItem;
            CourseListController.HandleSelectedCourse(subject);
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
