using Advisor.Models;
using Advisor.Services.Statistics;
using System.Linq;
using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Advisor.Controllers
{
    public class UniversityController : Controller, IUniversityController
    {
        public IStatsBuilder StatsBuilder { get; set; }

        public UniversityController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
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
                ViewBag.StatsData = LoadStats(uni);
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

        private StatsData LoadStats(University uni)
        {
            var stats = StatsBuilder.BuildUniversityStats(uni);
            StatsData statsData = new StatsData
            {
                OveralRating = stats.overal,
                FacultyCount = stats.faculty_count,
                StudyProgramCount = stats.study_program_count,
                Satisfaction = stats.satisfaction,
                AverageSalary = stats.salary,
                RelevantIndustryPercentage = stats.relevant_industry
            };

            return statsData;
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
    }
}
