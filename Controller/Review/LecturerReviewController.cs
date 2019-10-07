using Advisor.View;
using Advisor.Model;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    public class LecturerReviewController : ILecturerReviewController
    {
        public Lecturer Lecturer { get; set; }
        public LecturerReviewView LecturerReviewView { get; set; }
        public LecturerView LecturerView { get; set; }
        public LecturerReviewController(Lecturer lecturer, LecturerView lecturerView)
        {
            Lecturer = lecturer;
            LecturerView = lecturerView;
        }

        public void HandleSubmitReviewButtonClick()
        {
            int competence = Convert.ToInt32(LecturerReviewView.Competence.Value);
            int strictness = Convert.ToInt32(LecturerReviewView.Strictness.Value);
            int delivery = Convert.ToInt32(LecturerReviewView.Delivery.Value);
            int interesting = Convert.ToInt32(LecturerReviewView.Interesting.Value);
            int personality = Convert.ToInt32(LecturerReviewView.Personality.Value);
            int overalRating = Convert.ToInt32(LecturerReviewView.OveralRating.Value);
            string textReview = LecturerReviewView.TextReview.Text;
            Review review = new Review
            {
                Competence = competence,
                Strictness = strictness,
                Delivery = delivery,
                Interesting = interesting,
                Personality = personality,
                OveralRating = overalRating,
                Text = textReview
            };

            SaveReview(review);

            if (!review.Text.Equals(""))
                LecturerView.ReviewList.Items.Add(review);
            LecturerReviewView.Close();
        }

        public void SaveReview(Review review)
        {
            Random random = new Random();
            List<User> userList = DB.Instance.Users.ToList();
            review.UserId = userList.ElementAt(random.Next(0, userList.Count)).Id;      //TODO: set current user
            DB.Instance.Reviews.Add(review);
            Lecturer.Reviews.Add(review);
            DB.Instance.SaveChanges();
        }
    }
}
