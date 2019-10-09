using Advisor.Model;
using Advisor.Service.Statistics;
using Advisor.View;
using Advisor.View.Comparison;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Advisor.Controller
{
    public class FacultyController : IFacultyController
    {
        public FacultyView FacultyView { get; set; }
        public UniversityView UniversityView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }
        public LecturerView LecturerView { get; set; }
        public AddFormView AddFormView { get; set; }
        public Faculty Faculty { get; set; }
        public FacultyComparisonView FacultyComparisonView { get; set; }

        public FacultyController(Faculty faculty)
        {
            Faculty = faculty;
        }

        public void HandlePreviousButtonClick(University uni)
        {
            FacultyView.Hide();
            UniversityView = new UniversityView(new UniversityController(uni));
            UniversityView.Show();
        }

        public void LoadData()
        {
            FacultyView.StudyProgramList.Items.Clear();
            FacultyView.LecturerList.Items.Clear();
            FacultyView.Faculty = Faculty;
            List<StudyProgram> programs = Faculty.StudyPrograms.ToList();
            List<Lecturer> lecturers = Faculty.Lecturers.ToList();
            programs.ForEach(program => FacultyView.StudyProgramList.Items.Add(program));
            lecturers.ForEach(lecturer => FacultyView.LecturerList.Items.Add(lecturer));
            LoadStats();
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram, faculty, uni));
            StudyProgramView.Show();
        }

        public void HandleLecturerSelect(Lecturer lecturer)
        {
            FacultyView.Hide();
            LecturerView = new LecturerView(new LecturerController(lecturer));
            LecturerView.Show();
        }

        public void HandleAddStudyProgramClick()
        {
            AddFormView = new AddFormView();
            AddFormView.AddButtonClicked += HandleAddStudyProgram;
            AddFormView.TitleLabel.Text = "Add study program";
            AddFormView.ShowDialog();
        }

        public void HandleAddLecturerClick()
        {
            AddFormView = new AddFormView();
            AddFormView.AddButtonClicked += HandleAddLecturer;
            AddFormView.TitleLabel.Text = "Add lecturer";
            AddFormView.TextFieldLabel.Text = "Name:";
            AddFormView.DescriptionInput.Visible = false;
            AddFormView.DescriptionLabel.Visible = false;
            AddFormView.ShowDialog();
        }

        public void HandleAddLecturer(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer()
            {
                Name = AddFormView.TitleInput.Text,
                Faculty = FacultyView.Faculty
            };
            DB.Instance.Lecturers.Add(lecturer);
            DB.Instance.SaveChanges();
            FacultyView.LecturerList.Items.Add(lecturer);
            AddFormView.Close();
        }

        public void HandleAddStudyProgram(object sender, EventArgs e)
        {
            StudyProgram program = new StudyProgram()
            {
                Title = AddFormView.TitleInput.Text,
                Description = AddFormView.DescriptionInput.Text,
                Faculty = FacultyView.Faculty,
                Reviews = new Collection<Review>(),
                Courses = new Collection<Course>()
            };
            DB.Instance.StudyPrograms.Add(program);
            DB.Instance.SaveChanges();
            FacultyView.StudyProgramList.Items.Add(program);
            AddFormView.Close();
        }
        public void HandleCompareLink()
        {
            FacultyComparisonView = new FacultyComparisonView(new FacultyComparisonController());
            FacultyComparisonView.ShowDialog();
        }

        private void LoadStats()
        {
            StatsData statsData = new StatsData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> programReviews = (from r in DB.Instance.Reviews
                                          join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id 
                                          join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                          where f.Id == Faculty.Id
                                          select r).ToList();
            statsData.AverageSalary = calculator.CalcReviewAverage(programReviews, r => r.Salary, 1);
            statsData.Difficulty = calculator.CalcReviewAverage(programReviews, r => r.Difficulty, 1);
            statsData.Satisfaction = calculator.CalcReviewAverage(programReviews, r => r.Satisfaction, 1);
            statsData.OveralRating = calculator.CalcReviewAverage(programReviews, r => r.OveralRating, 1);

            FacultyView.StatsData = statsData;
        }
    }
}
