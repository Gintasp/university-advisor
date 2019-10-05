using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;

namespace Advisor.Controller
{
    public class CourseController : ICourseController
    {
        public CourseView CourseView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public CourseSelectFormView PopupCourseComparison { get; set; }
        public Course Course { get; set; }
        public StudyProgramView StudyProgramView { get; set; }
        public IStudyProgramController StudyProgramController { get; set; }

        public CourseController(
            StudyProgram studyProgram,
            Course course,
            IStudyProgramController studyProgramController
        ) {
            StudyProgram = studyProgram;
            Course = course;
            StudyProgramController = studyProgramController;
        }

        public void LoadCourseReviews()
        {
            List<Review> reviews = DB.Instance.Reviews.Where(r => r.Course.Id == Course.Id).ToList();
            foreach (Review review in reviews)
            {
                CourseView.ReviewList.Items.Add(review);
            }
        }

        public void HandlePreviousClicked()
        {
            CourseView.Hide();
            StudyProgramView = new StudyProgramView(StudyProgramController);
            StudyProgramView.Show();
        }
        public void DisplayPopup()
        {
            PopupCourseComparison = new CourseSelectFormView();
            PopupCourseComparison.ShowDialog();
        }
    }
}
