using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;

namespace Advisor.Controller
{
    public class CourseController : ICourseController
    {
        public CourseView CourseView { get; set; }
        public CourseListView CourseListView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public Course Course { get; set; }
        public CourseController(StudyProgram studyProgram, Course course)
        {
            StudyProgram = studyProgram;
            Course = course;
        }

        public void LoadCourseReviews()
        {
            List<Review> reviews = DB.Instance.Reviews.Where(r => r.Course.Id == Course.Id).ToList();
            foreach(Review review in reviews)
            {
                CourseView.ReviewList.Items.Add(review);
            }
        }

        public void HandlePreviousClicked()
        {
            CourseView.Hide();
            CourseListView = new CourseListView(new CourseListController(StudyProgram));
            CourseListView.Show();
        }
    }
}
