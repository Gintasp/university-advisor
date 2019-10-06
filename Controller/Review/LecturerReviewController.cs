using Advisor.View;
using Advisor.Model;
using System.IO;
using System;

namespace Advisor.Controller
{
    public class LecturerReviewController : ILecturerReviewController
    {
        public LecturerReviewView LecturerReviewView { get; set; }

        public void HandleSubmitReviewButtonClick()
        {
            throw new System.NotImplementedException();
        }

        public void SaveReview(Review review)
        {
            string dataFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Migrations\\Data\\Review.csv";
            File.AppendAllText(dataFolderPath, Environment.NewLine + review.AllToString());
        }
    }
}
