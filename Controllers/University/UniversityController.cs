using Advisor.Models;
using System.Linq;
using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Advisor.Controllers
{
    public class UniversityController : Controller, IUniversityController
    {
        public UniversityController()
        {
        }

        [Route("universities/{id?}", Name = "universities_page")]
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                University uni = DB.Instance.Universities.Where(u => u.Id == id).SingleOrDefault();
                if (uni == null)
                {
                    return View("/Views/Shared/404.cshtml");
                }

                ViewBag.University = uni;

                return View("/Views/University/University.cshtml");
            }

            return List();
        }

        private ActionResult List()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;

            return View("/Views/University/UniversityList.cshtml");
        }
        public void HandlePreviousButtonClick()
        {
            //UniversityView.Hide();
            //HomeView = new HomeView(new HomeController());
            //HomeView.ShowDialog();
        }

        public void HandleFacultySelect(Faculty faculty)
        {
            //FacultyView = new FacultyView(new FacultyController(faculty), University);
            //UniversityView.Hide();
            //FacultyView.ShowDialog();
        }

        public void HandleAddFacultyClick()
        {
            //AddFormView = new AddFormView();
            //AddFormView.AddButtonClicked += HandleAddFaculty;
            //AddFormView.TitleLabel.Text = "Add new faculty";
            //AddFormView.ShowDialog();
        }

        public void HandleAddFaculty(object sender, EventArgs e)
        {
            //Faculty fac = new Faculty()
            //{
            //    Title = AddFormView.TitleInput.Text,
            //    Description = AddFormView.DescriptionInput.Text,
            //    University = University,
            //    StudyPrograms = new Collection<StudyProgram>(),
            //    Lecturers = new Collection<Lecturer>()
            //};
            //DB.Instance.Faculties.Add(fac);
            //DB.Instance.SaveChanges();
            //UniversityView.FacultyList.Items.Add(fac);
            //AddFormView.Close();
        }

        public void HandleComparisonButtonClick()
        {
            //UniversityView.Hide();
            //UniversityComparisonView = new UniversityComparisonView(new UniversityComparisonController(), University);
            //UniversityComparisonView.ShowDialog();
        }

        private void LoadFacultyList()
        {
            //UniversityView.FacultyList.Items.Clear();
            //List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == University.Id).ToList();
            //faculties.ForEach(faculty => UniversityView.FacultyList.Items.Add(faculty));
        }

        private void LoadStats()
        {
            //StatsData statsData = new StatsData();
            //StatisticCalculator calculator = new StatisticCalculator();
            //List<Review> reviews = (from r in DB.Instance.Reviews
            //                               join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
            //                               join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
            //                               join u in DB.Instance.Universities on f.University.Id equals u.Id
            //                        where u.Id == University.Id
            //                        select r).ToList();
            //statsData.AverageSalary = calculator.CalcReviewAverage(reviews, r => r.Salary, 2);
            //statsData.OveralRating = calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1);
            //statsData.FacultyCount = University.Faculties.Count;
            //statsData.ReviewCount = reviews.Count;

            //UniversityView.StatsData = statsData;
        }

        public ActionResult UniversityList()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;

            return View("/Views/University/UniversityList.cshtml");
        }

        public void HandleAddUniversityClick()
        {
            //AddFormView = new AddFormView();
            //AddFormView.AddButtonClicked += HandleAddNewUniversity;
            //AddFormView.TitleLabel.Text = "Add new university";
            //AddFormView.ShowDialog();
        }

        public void HandleAddNewUniversity(object sender, EventArgs e)
        {
            //University uni = new University() {
            //    Title = AddFormView.TitleInput.Text,
            //    Description = AddFormView.DescriptionInput.Text
            //};
            //DB.Instance.Universities.Add(uni);
            //DB.Instance.SaveChanges();
            //HomeView.UniversityList.Items.Add(uni);
            //AddFormView.Close();
        }

        public void HandleUniversitySelect(University uni)
        {
            //HomeView.Hide();
            //UniversityView = new UniversityView(new UniversityController(uni));
            //UniversityView.ShowDialog();
        }

        public void HandleSearchBoxChange()
        {
            //if (!string.IsNullOrEmpty(HomeView.SearchBox.Text))
            //{
            //    List<University> unis = DB.Instance.Universities.ToList();
            //    HomeView.UniversityList.Items.Clear();
            //    foreach (University uni in unis)
            //    {
            //        if (uni.Title.ToLower().Contains(HomeView.SearchBox.Text.ToLower()))
            //        {
            //            HomeView.UniversityList.Items.Add(uni); 
            //        }
            //    }
            //}
            //else LoadUniversityList();
        }
    }
}
