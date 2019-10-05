using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class LecturerView : Form
    {
        public ILecturerController LecturerController { get; set; }
        public Lecturer Lecturer { get; set; }
        public ListBox ReviewList { get; set; }
        public ListBox CourseList { get; set; }

        public LecturerView(ILecturerController lecturerController)
        {
            LecturerController = lecturerController;
            LecturerController.LecturerView = this;
            InitializeComponent();
            CourseList = CourseData;
            ReviewList = ReviewData;
        }

        private void OnViewLoad(object sender, System.EventArgs e)
        {
            LecturerController.LoadLecturerData();
            labelName.Text = Lecturer.Name;
            labelFaculty.Text = Lecturer.Faculty.Title;
        }

        private void OnLeaveReviewButtonClick(object sender, System.EventArgs e)
        {
            LecturerController.HandleLeaveReviewClick();
        }

        private void OnPreviousFormLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LecturerController.HandlePreviousFormClick();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Course select code
        //
        //private void OnCourseSelect(object sender, System.EventArgs e)
        //{
        //    Course course = (Course)CourseData.SelectedItem;
        //    if (course != null)
        //    {
        //        LecturerController.HandleCourseSelect(course);
        //    }
        //}


        //Course Add Code
        //
        //private void OnAddCourseLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    LecturerController.HandleAddCourseClick();
        //}
    }
}
