using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;
using System;

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

        private float CalcAverage(List<Review> list, Func<Review, int> prop, int decimalPlaces)
        {
            if (list.Count != 0)
            {
                return (float) Math.Round((double) list.Sum(r => prop(r)) / list.Count, decimalPlaces);
            }

            return 0;
        }

        private void LoadStats()
        {
            ReviewData reviewData = new ReviewData();
            List<Review> courseReviews = Course.Reviews.ToList();
            reviewData.Usefulness = CalcAverage(courseReviews, r => r.Usefulness, 1);
            reviewData.Difficulty = CalcAverage(courseReviews, r => r.Difficulty, 1);
            reviewData.Satisfaction = CalcAverage(courseReviews, r => r.Satisfaction, 1);
            reviewData.OveralRating = CalcAverage(courseReviews, r => r.OveralRating, 1);
            reviewData.Theory = CalcAverage(courseReviews, r => r.TheoryPercentage, 1);
            reviewData.Practice = CalcAverage(courseReviews, r => r.PracticePercentage, 1);

            CourseView.ReviewData = reviewData;
        }

        private void LoadReviews()
        {
            List<Review> reviews = DB.Instance.Reviews.Where(r => r.Course.Id == Course.Id).ToList();
            reviews.ForEach(review => CourseView.ReviewList.Items.Add(review));
        }
    }
}
