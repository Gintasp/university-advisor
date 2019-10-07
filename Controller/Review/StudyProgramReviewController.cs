using Advisor.View;
using Advisor.Model;
using System;
using System.IO;
using Advisor.Service.Statistics;
using System.Collections.Generic;
using System.Linq;

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

                Review review = new Review
                {
                    Salary = Salary,
                    Difficulty = Difficulty,
                    Satisfaction = Satisfaction,
                    RelevantIndustry = RelevantIndustry,
                    CareerStartYear = CareerStartYear,
                    OveralRating = OveralRating,
                    Text = Text
                };
                SaveReview(review);

                if (!review.Text.Equals(""))
                    StudyProgramView.ReviewList.Items.Add(review);
                LoadStats();
                StudyProgramReviewView.Close();
            }            
        }

        public void SaveReview(Review review)
        {
            using (var context = new DatabaseContext())
            {
                Random random = new Random();
                List<User> userList = context.Users.ToList();
                review.UserId = userList.ElementAt(random.Next(0, userList.Count)).Id;
                context.Reviews.Add(review);
                context.SaveChanges();

            }
            StudyProgram.Reviews.Add(review);
        }
        private void LoadStats()
        {
            StatsData statsData = new StatsData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> programReviews = StudyProgram.Reviews.ToList();
            statsData.AverageSalary = calculator.CalcReviewAverage(programReviews, r => r.Salary, 1);
            statsData.Difficulty = calculator.CalcReviewAverage(programReviews, r => r.Difficulty, 1);
            statsData.Satisfaction = calculator.CalcReviewAverage(programReviews, r => r.Satisfaction, 1);
            statsData.OveralRating = calculator.CalcReviewAverage(programReviews, r => r.OveralRating, 1);

            StudyProgramView.StatsData = statsData;
        }
    }
}
