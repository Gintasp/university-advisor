using Advisor.Model;
using Advisor.View;
using System.IO;
using System;

namespace Advisor.Controller
{
    public class CourseReviewController : ICourseReviewController
    {
        public CourseReviewView CourseReviewView { get; set; }
        public Course Course { get; set; }
        public CourseView CourseView { get; set; }
        public int Difficulty { get; set; }
        public int Satisfaction { get; set; }
        public int Usefulness { get; set; }
        public int Interesting { get; set; }
        public int OveralRating { get; set; }
        public int TheoryPercentage { get; set; }
        public int PracticePercentage { get; set; }
        public string TextReview { get; set; }
        public CourseReviewController(Course course, CourseView courseView)
        {
            Course = course;
            CourseView = courseView;
        }

        public void HandleSubmitReviewButtonClick()
        {
            Difficulty = Convert.ToInt32(CourseReviewView.Difficulty.Value);
            Satisfaction = Convert.ToInt32(CourseReviewView.Satisfaction.Value);
            Usefulness = Convert.ToInt32(CourseReviewView.Usefulness.Value);
            Interesting = Convert.ToInt32(CourseReviewView.Interesting.Value);
            OveralRating = Convert.ToInt32(CourseReviewView.OveralRating.Value);
            TheoryPercentage = Convert.ToInt32(CourseReviewView.TheoryPercentage.Value);
            PracticePercentage = Convert.ToInt32(CourseReviewView.PracticePercentage.Value);
            TextReview = CourseReviewView.TextReview.Text;
            Review review = new Review(Difficulty, Satisfaction, Usefulness, Interesting, OveralRating, TheoryPercentage, PracticePercentage, TextReview);
            Course.Reviews.Add(review);
            CourseView.ReviewList.Items.Add(review);
            SaveReview(review);
            CourseReviewView.Close();
        }

        public void SaveReview(Review review)
        {
            string dataFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Migrations\\Data\\Review.csv";
            File.AppendAllText(dataFolderPath, Environment.NewLine + review.AllToString());
        }
    }
}
