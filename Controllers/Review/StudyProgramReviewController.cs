using Advisor.Models;

namespace Advisor.Controllers
{
    public class StudyProgramReviewController : IStudyProgramReviewController
    {
        enum StartYear
        {
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4
        }

        public StudyProgram StudyProgram { get; set; }

        public void HandleSubmitReviewButtonClick()
        {
            //if(!StudyProgramReviewView.Income.Text.Equals(""))
            //{
            //    int salary;
            //    try
            //    {
            //        salary = Convert.ToInt32(StudyProgramReviewView.Income.Text);
            //    }
            //    catch(FormatException)
            //    {
            //        StudyProgramReviewView.Income.BackColor = Color.Yellow;
            //        return;
            //    }
            //    int difficulty = Convert.ToInt32(StudyProgramReviewView.Difficulty.Value.ToString());
            //    int satisfaction = Convert.ToInt32(StudyProgramReviewView.Satisfaction.Value.ToString());

            //    bool relevantIndustry = StudyProgramReviewView.RelevantIndustry.Checked;
            //    int careerStartYear;
            //    if (StudyProgramReviewView.FirstYear.Checked)
            //        careerStartYear = (int)StartYear.First;
            //    else if (StudyProgramReviewView.SecondYear.Checked)
            //        careerStartYear = (int)StartYear.Second;
            //    else if (StudyProgramReviewView.ThirdYear.Checked)
            //        careerStartYear = (int)StartYear.Third;
            //    else
            //        careerStartYear = (int)StartYear.Fourth;
            //    int overalRating = Convert.ToInt32(StudyProgramReviewView.Rating.Value.ToString());
            //    string text = StudyProgramReviewView.TextReview.Text;

            //    Review review = new Review
            //    {
            //        Salary = salary,
            //        Difficulty = difficulty,
            //        Satisfaction = satisfaction,
            //        RelevantIndustry = relevantIndustry,
            //        CareerStartYear = careerStartYear,
            //        OverallRating = overalRating,
            //        Text = text
            //    };
            //    SaveReview(review);

            //    if (!review.Text.Equals(""))
            //        StudyProgramView.ReviewList.Items.Add(review);
            //    StudyProgramReviewView.Close();
            //}            
        }

        public void SaveReview(Review review)
        {
            //Random random = new Random();
            //List<User> userList = DB.Instance.Users.ToList();
            //review.UserId = SessionStorage.Instance.User.Id;
            //DB.Instance.Reviews.Add(review);
            //StudyProgram.Reviews.Add(review);
            //DB.Instance.SaveChanges();
        }
    }
}
