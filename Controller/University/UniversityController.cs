using Advisor.Model;
using Advisor.View;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using Advisor.Service.Statistics;
using Advisor.View.Comparison;

namespace Advisor.Controller
{
    public class UniversityController : IUniversityController
    {
        public UniversityView UniversityView { get; set; }
        public FacultyView FacultyView { get; set; }
        public HomeView HomeView { get; set; }
        public AddFormView AddFormView { get; set; }
        public University University { get; set; }
        public UniversityComparisonView UniversityComparisonView {get; set; }

        public UniversityController(University uni)
        {
            University = uni;
        }

        public void HandlePreviousButtonClick()
        {
            UniversityView.Hide();
            HomeView = new HomeView(new HomeController());
            HomeView.ShowDialog();
        }
        public void LoadData()
        {
            LoadFacultyList();
            LoadStats();
            UniversityView.University = University;
        }

        public void HandleFacultySelect(Faculty faculty)
        {
            FacultyView = new FacultyView(new FacultyController(faculty), University);
            UniversityView.Hide();
            FacultyView.ShowDialog();
        }

        public void HandleAddFacultyClick()
        {
            AddFormView = new AddFormView();
            AddFormView.AddButtonClicked += HandleAddFaculty;
            AddFormView.TitleLabel.Text = "Add new faculty";
            AddFormView.ShowDialog();
        }

        public void HandleAddFaculty(object sender, EventArgs e)
        {
            Faculty fac = new Faculty()
            {
                Title = AddFormView.TitleInput.Text,
                Description = AddFormView.DescriptionInput.Text,
                University = University,
                StudyPrograms = new Collection<StudyProgram>(),
                Lecturers = new Collection<Lecturer>()
            };
            DB.Instance.Faculties.Add(fac);
            DB.Instance.SaveChanges();
            UniversityView.FacultyList.Items.Add(fac);
            AddFormView.Close();
        }
        public void HandleComparisonButtonClick()
        {
            UniversityView.Hide();
            UniversityComparisonView = new UniversityComparisonView(new UniversityComparisonController(), University);
            UniversityComparisonView.ShowDialog();
        }

        private void LoadFacultyList()
        {
            UniversityView.FacultyList.Items.Clear();
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == University.Id).ToList();
            faculties.ForEach(faculty => UniversityView.FacultyList.Items.Add(faculty));
        }

        private void LoadStats()
        {
            StatsData statsData = new StatsData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> reviews = (from r in DB.Instance.Reviews
                                           join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                           join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                           join u in DB.Instance.Universities on f.University.Id equals u.Id
                                    where u.Id == University.Id
                                    select r).ToList();
            statsData.AverageSalary = calculator.CalcReviewAverage(reviews, r => r.Salary, 2);
            statsData.OveralRating = calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1);
            statsData.FacultyCount = University.Faculties.Count;
            statsData.ReviewCount = reviews.Count;

            UniversityView.StatsData = statsData;
        }

    }
}
