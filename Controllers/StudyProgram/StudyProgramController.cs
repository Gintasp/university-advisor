using System;
using System.Collections.Generic;
using Advisor.Model;
using System.Linq;
using System.Collections.ObjectModel;
using Advisor.Service.Statistics;
using Advisor.Service.Validator;

namespace Advisor.Controllers
{
    public class StudyProgramController : IStudyProgramController
    {
        public StudyProgram StudyProgram { get; set; }
        public Faculty Faculty { get; set; }
        public University University { get; set; }

        public StudyProgramController(StudyProgram studyProgram, Faculty faculty, University uni)
        {
            StudyProgram = studyProgram;
            Faculty = faculty;
            University = uni;
        }

        public void LoadStudyProgramData()
        {
            //StudyProgramView.StudyProgram = StudyProgram;
            //StudyProgramView.ReviewList.Items.Clear();
            //StudyProgramView.CourseList.Items.Clear();
            //List<Review> reviews = StudyProgram.Reviews.ToList();
            //List<Course> courses = StudyProgram.Courses.ToList();
            //reviews.ForEach(review => StudyProgramView.ReviewList.Items.Add(review));
            //courses.ForEach(course => StudyProgramView.CourseList.Items.Add(course));
            //LoadStats();
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

        public void HandlePreviousButtonClick()
        {
            //StudyProgramView.Hide();
            //FacultyView = new FacultyView(new FacultyController(Faculty), University);
            //FacultyView.Show();
        }

        public void HandleAddCourseLinkClick()
        {
            LoadAddForm();
            //AddFormView.ShowDialog();
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

        public void HandleCompareButtonClick()
        {
            //StudyProgramView.Hide();
            //ComparisonView = new StudyProgramComparisonView(new StudyProgramComparisonController(StudyProgramView));
            //ComparisonView.Show();
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

        public void HandleCourseSelect(Course course)
        {
            //StudyProgramView.Hide();
            //CourseView = new CourseView(new CourseController(StudyProgram, course, this), course);
            //CourseView.Show();
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
