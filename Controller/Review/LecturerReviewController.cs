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
        public int Competence { get; set; }
        public int Strictness { get; set; }
        public int Delivery { get; set; }
        public int Interesting { get; set; }
        public int Personality { get; set; }
        public int OveralRating { get; set; }
        public string TextReview { get; set; }
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
            Competence = Convert.ToInt32(LecturerReviewView.Competence.Value);
            Strictness = Convert.ToInt32(LecturerReviewView.Strictness.Value);
            Delivery = Convert.ToInt32(LecturerReviewView.Delivery.Value);
            Interesting = Convert.ToInt32(LecturerReviewView.Interesting.Value);
            Personality = Convert.ToInt32(LecturerReviewView.Personality.Value);
            OveralRating = Convert.ToInt32(LecturerReviewView.OveralRating.Value);
            TextReview = LecturerReviewView.TextReview.Text;
            Review review = new Review
            {
                Competence = Competence,
                Strictness = Strictness,
                Delivery = Delivery,
                Interesting = Interesting,
                Personality = Personality,
                OveralRating = OveralRating,
                Text = TextReview
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
            review.UserId = userList.ElementAt(random.Next(0, userList.Count)).Id;
            Lecturer lecturer = DB.Instance.Lecturers.Where(r => r.Id == Lecturer.Id).FirstOrDefault();
            DB.Instance.Reviews.Add(review);
            lecturer.Reviews.Add(review);
            DB.Instance.SaveChanges();
        }
    }
}
