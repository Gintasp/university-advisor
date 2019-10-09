using Advisor.Model;
using Advisor.Service.Auth;
using Advisor.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    public class CourseReviewController : ICourseReviewController
    {
        public CourseReviewView CourseReviewView { get; set; }
        public Course Course { get; set; }
        public CourseView CourseView { get; set; } 
        public CourseReviewController(Course course, CourseView courseView)
        {
            Course = course;
            CourseView = courseView;
        }

        public void HandleSubmitReviewButtonClick()
        {
            int difficulty = Convert.ToInt32(CourseReviewView.Difficulty.Value);
            int satisfaction = Convert.ToInt32(CourseReviewView.Satisfaction.Value);
            int usefulness = Convert.ToInt32(CourseReviewView.Usefulness.Value);
            int interesting = Convert.ToInt32(CourseReviewView.Interesting.Value);
            int overalRating = Convert.ToInt32(CourseReviewView.OveralRating.Value);
            int theoryPercentage = Convert.ToInt32(CourseReviewView.TheoryPercentage.Value);
            int practicePercentage = Convert.ToInt32(CourseReviewView.PracticePercentage.Value);
            string textReview = CourseReviewView.TextReview.Text;

            Review review = new Review
            {
                Difficulty = difficulty,
                Satisfaction = satisfaction,
                Usefulness = usefulness,
                Interesting = interesting,
                OveralRating = overalRating,
                TheoryPercentage = theoryPercentage,
                PracticePercentage =practicePercentage,
                Text = textReview
            };
            SaveReview(review);
            if (!review.Text.Equals(""))
                CourseView.ReviewList.Items.Add(review);
            CourseReviewView.Close();
        }

        public void SaveReview(Review review)
        {
            Random random = new Random();
            List<User> userList = DB.Instance.Users.ToList();
            review.UserId = SessionStorage.Instance.User.Id;
            DB.Instance.Reviews.Add(review);
            Course.Reviews.Add(review);
            DB.Instance.SaveChanges();
        }
    }
}
