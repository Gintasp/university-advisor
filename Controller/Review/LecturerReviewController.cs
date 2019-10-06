using Advisor.View;
using Advisor.Model;
using System.IO;
using System;

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
            Review review = new Review(Competence, Strictness, Delivery, Interesting, Personality, OveralRating, TextReview);
            Lecturer.Reviews.Add(review);
            if (!review.Text.Equals(""))
                LecturerView.ReviewList.Items.Add(review);
            SaveReview(review);
            LecturerReviewView.Close();
        }

        public void SaveReview(Review review)
        {
            string dataFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Migrations\\Data\\Review.csv";
            File.AppendAllText(dataFolderPath, Environment.NewLine + review.AllToString());
        }
    }
}
