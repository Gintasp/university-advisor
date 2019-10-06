using System.Collections.Generic;
using System.Linq;
using Advisor.View;
using Advisor.Model;

namespace Advisor.Controller
{
    public class LecturerController : ILecturerController
    {
        public LecturerView LecturerView { get; set; }
        public LecturerReviewView LecturerReviewView { get; set; }
        public FacultyView FacultyView { get; set; }
        public CourseView CourseView { get; set; }
        public AddFormView AddFormView { get; set; }
        public Lecturer Lecturer { get; set; }

        public LecturerController(Lecturer lecturer)
        {
            Lecturer = lecturer;
        }

        public void LoadLecturerData()
        {
            LecturerView.Lecturer = Lecturer;
            LecturerView.CourseList.Items.Clear();
            LecturerView.ReviewList.Items.Clear();

            if (Lecturer.Courses != null)
            {
                List<Course> courses = Lecturer.Courses.ToList();
                courses.ForEach(course => LecturerView.CourseList.Items.Add(course));
            }
            
            if (Lecturer.Reviews != null)
            {
                List<Review> reviews = Lecturer.Reviews.ToList();
                reviews.ForEach(review => LecturerView.ReviewList.Items.Add(review));
            }
        }

        public void HandleLeaveReviewClick()
        {
            LecturerReviewView = new LecturerReviewView(new LecturerReviewController());
            LecturerReviewView.ShowDialog();
        }

        public void HandlePreviousFormClick()
        {
            LecturerView.Hide();
            FacultyView = new FacultyView(new FacultyController(Lecturer.Faculty), Lecturer.Faculty.University);
            FacultyView.Show();
        }
    }
}
