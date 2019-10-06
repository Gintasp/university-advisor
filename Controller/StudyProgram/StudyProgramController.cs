using System;
using System.Collections.Generic;
using Advisor.Model;
using Advisor.View;
using System.Linq;
using System.Collections.ObjectModel;
using Advisor.Service.Statistics;

namespace Advisor.Controller
{
    public class StudyProgramController : IStudyProgramController
    {
        public StudyProgramView StudyProgramView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public Faculty Faculty { get; set; }
        public FacultyView FacultyView { get; set; }
        public University University { get; set; }
        public AddFormView AddFormView { get; set; }
        public CourseView CourseView { get; set; }

        public StudyProgramController(StudyProgram studyProgram, Faculty faculty, University uni)
        {
            StudyProgram = studyProgram;
            Faculty = faculty;
            University = uni;
        }

        public void LoadStudyProgramData()
        {
            StudyProgramView.StudyProgram = StudyProgram;
            StudyProgramView.ReviewList.Items.Clear();
            StudyProgramView.CourseList.Items.Clear();
            List<Review> reviews = StudyProgram.Reviews.ToList();
            List<Course> courses = StudyProgram.Courses.ToList();
            reviews.ForEach(review => StudyProgramView.ReviewList.Items.Add(review));
            courses.ForEach(course => StudyProgramView.CourseList.Items.Add(course));
            LoadStats();
        }

        private void LoadStats()
        {
            ReviewData reviewData = new ReviewData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> programReviews = StudyProgram.Reviews.ToList();
            reviewData.AverageSalary = calculator.CalcReviewAverage(programReviews, r => r.Salary, 1);
            reviewData.Difficulty = calculator.CalcReviewAverage(programReviews, r => r.Difficulty, 1);
            reviewData.Satisfaction = calculator.CalcReviewAverage(programReviews, r => r.Satisfaction, 1);
            reviewData.OveralRating = calculator.CalcReviewAverage(programReviews, r => r.OveralRating, 1);

            StudyProgramView.StatsReviewData = reviewData;
        }

        public void HandlePreviousButtonClick()
        {
            StudyProgramView.Hide();
            FacultyView = new FacultyView(new FacultyController(Faculty), University);
            FacultyView.Show();
        }

        public void HandleAddCourseLinkClick()
        {
            LoadAddForm();
            AddFormView.ShowDialog();
        }

        public void HandleAddCourse(object sender, EventArgs e)
        {
            Course course = new Course()
            {
                Title = AddFormView.TitleInput.Text,
                Lecturer = (Lecturer)AddFormView.LecturerComboBox.SelectedItem,
                StudyProgram = StudyProgram,
                Reviews = new Collection<Review>()
            };
            DB.Instance.Courses.Add(course);
            DB.Instance.SaveChanges();
            StudyProgramView.CourseList.Items.Add(course);
            AddFormView.Close();
        }

        public void HandleLeaveReviewClick()
        {
            //TODO: Handle leave review
        }

        public void HandleCourseSelect(Course course)
        {
            CourseView = new CourseView(new CourseController(StudyProgram, course, this), course);
            CourseView.Show();
        }

        private void LoadAddForm()
        {
            AddFormView = new AddFormView();
            AddFormView.TitleLabel.Text = "Add course";
            AddFormView.DescriptionInput.Visible = false;
            AddFormView.DescriptionLabel.Visible = false;
            AddFormView.LecturerComboBox.Visible = true;
            AddFormView.LecturerLabel.Visible = true;
            AddFormView.AddButtonClicked += HandleAddCourse;
            List<Lecturer> lecturers = Faculty.Lecturers.ToList();
            lecturers.ForEach(lecturer => AddFormView.LecturerComboBox.Items.Add(lecturer));
        }
    }
}
