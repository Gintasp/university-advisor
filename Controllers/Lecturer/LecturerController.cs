namespace Advisor.Controllers
{
    public class LecturerController : ILecturerController
    {
        public LecturerController()
        {
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
    }
}
