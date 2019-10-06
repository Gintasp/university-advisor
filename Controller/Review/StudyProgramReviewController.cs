using Advisor.View;
using Advisor.Model;
using System;
using System.IO;

namespace Advisor.Controller
{
    public class StudyProgramReviewController : IStudyProgramReviewController
    {
        public int Salary { get; set; }
        public int Difficulty { get; set; }
        public int Satisfaction { get; set; }
        public bool RelevantIndustry { get; set; }
        public int CareerStartYear { get; set; }
        public int OveralRating { get; set; }
        public string Text { get; set; }
        public StudyProgramReviewView StudyProgramReviewView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }
        public StudyProgram StudyProgram { get; set; }

        public StudyProgramReviewController(StudyProgramView studyProgramView, StudyProgram studyProgram)
        {
            StudyProgramView = studyProgramView;
            StudyProgram = studyProgram;
        }
        public void HandleSubmitReviewButtonClick()
        {
            if(!StudyProgramReviewView.Income.Text.Equals("") &&
                (StudyProgramReviewView.RelevantIndustry.Checked || StudyProgramReviewView.IrrelevantIndustry.Checked) &&
                (StudyProgramReviewView.FirstYear.Checked || StudyProgramReviewView.SecondYear.Checked || 
                StudyProgramReviewView.ThirdYear.Checked || StudyProgramReviewView.FourthYear.Checked))
            {
                Salary = Convert.ToInt32(StudyProgramReviewView.Income.Text);
                Difficulty = Convert.ToInt32(StudyProgramReviewView.Difficulty.Value.ToString());
                Satisfaction = Convert.ToInt32(StudyProgramReviewView.Satisfaction.Value.ToString());
                if (StudyProgramReviewView.RelevantIndustry.Checked)
                    RelevantIndustry = true;
                else
                    RelevantIndustry = false;
                if (StudyProgramReviewView.FirstYear.Checked)
                    CareerStartYear = 1;
                else if (StudyProgramReviewView.SecondYear.Checked)
                    CareerStartYear = 2;
                else if (StudyProgramReviewView.ThirdYear.Checked)
                    CareerStartYear = 3;
                else
                    CareerStartYear = 4;
                OveralRating = Convert.ToInt32(StudyProgramReviewView.Rating.Value.ToString());
                Text = StudyProgramReviewView.TextReview.Text;
            }

            Review review = new Review(Salary,Difficulty,Satisfaction,RelevantIndustry,CareerStartYear,OveralRating,Text);
            StudyProgram.Reviews.Add(review);
            StudyProgramView.ReviewList.Items.Add(review);
            string dataFolderPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Migrations\\Data\\Review.csv";
            File.AppendAllText(dataFolderPath, Environment.NewLine + review.AllToString());            
            StudyProgramReviewView.Close();
        }
    }
}
