using Advisor.Models;
namespace Advisor.Controllers
{
    public class LecturerController : ILecturerController
    {
        public Lecturer Lecturer { get; set; }

        public LecturerController(Lecturer lecturer)
        {
            Lecturer = lecturer;
        }

        public void LoadLecturerData()
        {
            //LecturerView.Lecturer = Lecturer;
            //LecturerView.CourseList.Items.Clear();
            //LecturerView.ReviewList.Items.Clear();

            //if (Lecturer.Courses != null)
            //{
            //    List<Course> courses = Lecturer.Courses.ToList();
            //    courses.ForEach(course => LecturerView.CourseList.Items.Add(course));
            //}
            
            //if (Lecturer.Reviews != null)
            //{
            //    List<Review> reviews = Lecturer.Reviews.ToList();
            //    reviews.ForEach(review => LecturerView.ReviewList.Items.Add(review));
            //}
        }

        public void HandleLeaveReviewClick()
        {
            //ReviewValidator validator = new ReviewValidator();
            //if (validator.Validate(Lecturer))
            //{
            //    LecturerReviewView = new LecturerReviewView(new LecturerReviewController(Lecturer, LecturerView));
            //    LecturerReviewView.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("You have already left a review.");
            //}
        }

        public void HandlePreviousFormClick()
        {
            //LecturerView.Hide();
            //FacultyView = new FacultyView(new FacultyController(Lecturer.Faculty), Lecturer.Faculty.University);
            //FacultyView.Show();
        }

        public void HandleComparisonButtonClick()
        {
            //LecturerView.Hide();
            //LecturerComparisonView = new LecturerComparisonView(new LecturerComparisonController(), Lecturer);
            //LecturerComparisonView.ShowDialog();
        }
    }
}
