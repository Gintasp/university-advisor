using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;
using Advisor.View.Comparison;
using Advisor.Service.Statistics;

namespace Advisor.Controller
{
    public class CourseController : ICourseController
    {
        public CourseView CourseView { get; set; }
        public CourseReviewView CourseReviewView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public SelectPopup SelectPopup { get; set; }
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

        public void LoadCourseData()
        {
            LoadReviews();
            LoadStats();
        }

        public void HandlePreviousClicked()
        {
            CourseView.Hide();
            StudyProgramView = new StudyProgramView(StudyProgramController);
            StudyProgramView.Show();
        }

        private void LoadStats()
        {
            StatsData statsData = new StatsData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> courseReviews = Course.Reviews.ToList();
            statsData.Usefulness = calculator.CalcReviewAverage(courseReviews, r => r.Usefulness, 1);
            statsData.Difficulty = calculator.CalcReviewAverage(courseReviews, r => r.Difficulty, 1);
            statsData.Satisfaction = calculator.CalcReviewAverage(courseReviews, r => r.Satisfaction, 1);
            statsData.OveralRating = calculator.CalcReviewAverage(courseReviews, r => r.OveralRating, 1);
            statsData.Theory = calculator.CalcReviewAverage(courseReviews, r => r.TheoryPercentage, 1);
            statsData.Practice = calculator.CalcReviewAverage(courseReviews, r => r.PracticePercentage, 1);

            CourseView.StatsData = statsData;
        }

        private void LoadReviews()
        {
            List<Review> reviews = DB.Instance.Reviews.Where(r => r.Course.Id == Course.Id).ToList();
            reviews.ForEach(review => CourseView.ReviewList.Items.Add(review));
        }
        public void HandleLeaveReviewClick()
        {
            CourseReviewView = new CourseReviewView(new CourseReviewController());
            CourseReviewView.ShowDialog();
        }
    }
}
