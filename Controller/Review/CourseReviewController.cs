using Advisor.Model;
using Advisor.View;
using System.IO;
using System;

namespace Advisor.Controller
{
    public class CourseReviewController : ICourseReviewController
    {
        public CourseReviewView CourseReviewView { get; set; }

        public void HandleSubmitReviewButtonClick()
        {
            //TODO: Handle sending course review
        }

        public void SaveReview(Review review)
        {
            string dataFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Migrations\\Data\\Review.csv";
            File.AppendAllText(dataFolderPath, Environment.NewLine + review.AllToString());
        }
    }
}
