using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;
using System;
using Advisor.Service.Statistics;

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
            ReviewData reviewData = new ReviewData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> courseReviews = Course.Reviews.ToList();
            reviewData.Usefulness = calculator.CalcReviewAverage(courseReviews, r => r.Usefulness, 1);
            reviewData.Difficulty = calculator.CalcReviewAverage(courseReviews, r => r.Difficulty, 1);
            reviewData.Satisfaction = calculator.CalcReviewAverage(courseReviews, r => r.Satisfaction, 1);
            reviewData.OveralRating = calculator.CalcReviewAverage(courseReviews, r => r.OveralRating, 1);
            reviewData.Theory = calculator.CalcReviewAverage(courseReviews, r => r.TheoryPercentage, 1);
            reviewData.Practice = calculator.CalcReviewAverage(courseReviews, r => r.PracticePercentage, 1);

            CourseView.ReviewData = reviewData;
        }

        private void LoadReviews()
        {
            List<Review> reviews = DB.Instance.Reviews.Where(r => r.Course.Id == Course.Id).ToList();
            reviews.ForEach(review => CourseView.ReviewList.Items.Add(review));
        }
    }
}
