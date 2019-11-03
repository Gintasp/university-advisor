using Advisor.Models;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Advisor.Services.Statistics;

namespace Advisor.Controllers
{
    public class StudyProgramController : Controller, IStudyProgramController
    {
        public StudyProgram StudyProgram { get; set; }
        public Faculty Faculty { get; set; }
        public University University { get; set; }

        public StudyProgramController()
        {
        }

        [Route("programs/{id?}", Name = "program_page")]
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                StudyProgram studyProgram = DB.Instance.StudyPrograms.Where(s => s.Id == id).SingleOrDefault();
                if (studyProgram == null)
                {
                    return View("/Views/Shared/404.cshtml");
                }

                ViewBag.StudyProgram = studyProgram;
                ViewBag.StatsData = LoadStats(studyProgram);

                return View("/Views/StudyProgram/StudyProgram.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }

        private StatsData LoadStats(StudyProgram studyProgram)
        {
            StatsData statsData = new StatsData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> studyProgramReviews = (from r in DB.Instance.Reviews
                                           join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                           where p.Id == studyProgram.Id
                                           select r).ToList();
            statsData.OveralRating = calculator.CalcReviewAverage(studyProgramReviews, r => r.OveralRating, 1);
            statsData.Satisfaction = calculator.CalcReviewAverage(studyProgramReviews, r => r.Satisfaction, 1);
            statsData.AverageSalary = calculator.CalcReviewAverage(studyProgramReviews, r => r.Salary, 1);
            statsData.ReviewCount = studyProgramReviews.Count;
            if (statsData.ReviewCount != 0)
                statsData.RelevantIndustryPercentage = studyProgramReviews.Count(r => r.RelevantIndustry == true) * 100 / statsData.ReviewCount;

            return statsData;
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

            //StudyProgramView.StatsData = statsData;
        }

        public void HandleAddCourse(object sender, EventArgs e)
        {
            //Course course = new Course()
            //{
            //    Title = AddFormView.TitleInput.Text,
            //    Lecturer = (Lecturer)AddFormView.LecturerComboBox.SelectedItem,
            //    StudyProgram = StudyProgram,
            //    Reviews = new Collection<Review>()
            //};
            //DB.Instance.Courses.Add(course);
            //DB.Instance.SaveChanges();
            //StudyProgramView.CourseList.Items.Add(course);
            //AddFormView.Close();
        }

        public void HandleLeaveReviewClick()
        {
            //ReviewValidator validator = new ReviewValidator();
            //if (validator.Validate(StudyProgram))
            //{
            //    StudyProgramReviewView = new StudyProgramReviewView(new StudyProgramReviewController(StudyProgramView, StudyProgram));
            //    StudyProgramReviewView.ShowDialog();
            //    LoadStats();
            //}
            //else
            //{
            //    MessageBox.Show("You have already left a review.");
            //}
        }

        private void LoadAddForm()
        {
            //AddFormView = new AddFormView();
            //AddFormView.TitleLabel.Text = "Add course";
            //AddFormView.DescriptionInput.Visible = false;
            //AddFormView.DescriptionLabel.Visible = false;
            //AddFormView.LecturerComboBox.Visible = true;
            //AddFormView.LecturerLabel.Visible = true;
            //AddFormView.AddButtonClicked += HandleAddCourse;
            //List<Lecturer> lecturers = Faculty.Lecturers.ToList();
            //lecturers.ForEach(lecturer => AddFormView.LecturerComboBox.Items.Add(lecturer));
        }
    }
}
