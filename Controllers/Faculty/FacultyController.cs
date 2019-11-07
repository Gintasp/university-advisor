using Advisor.Models;
using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using Advisor.Services.Statistics;

namespace Advisor.Controllers
{
    public class FacultyController : Controller, IFacultyController
    {
        public IStatsBuilder StatsBuilder { get; set; }
        public FacultyController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }

        [Route("faculties/{id?}", Name = "faculty_page")]
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                Faculty faculty = DB.Instance.Faculties.Where(u => u.Id == id).SingleOrDefault();
                if (faculty == null)
                {
                    return View("/Views/Shared/404.cshtml");
                }

                ViewBag.Faculty = faculty;
                ViewBag.StatsData = LoadStats(faculty);
                ViewBag.Address = faculty.Addresses.ToList().ElementAt(0).ToString();

                return View("/Views/Faculty.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }

        public void LoadData()
        {
            //FacultyView.StudyProgramList.Items.Clear();
            //FacultyView.LecturerList.Items.Clear();
            //FacultyView.Faculty = Faculty;
            //List<StudyProgram> programs = Faculty.StudyPrograms.ToList();
            //List<Lecturer> lecturers = Faculty.Lecturers.ToList();
            //programs.ForEach(program => FacultyView.StudyProgramList.Items.Add(program));
            //lecturers.ForEach(lecturer => FacultyView.LecturerList.Items.Add(lecturer));
            //LoadStats();
        }

        public void HandleAddStudyProgramClick()
        {
            //AddFormView = new AddFormView();
            //AddFormView.AddButtonClicked += HandleAddStudyProgram;
            //AddFormView.TitleLabel.Text = "Add study program";
            //AddFormView.ShowDialog();
        }

        public void HandleAddLecturerClick()
        {
            //AddFormView = new AddFormView();
            //AddFormView.AddButtonClicked += HandleAddLecturer;
            //AddFormView.TitleLabel.Text = "Add lecturer";
            //AddFormView.TextFieldLabel.Text = "Name:";
            //AddFormView.DescriptionInput.Visible = false;
            //AddFormView.DescriptionLabel.Visible = false;
            //AddFormView.ShowDialog();
        }

        public void HandleAddLecturer(object sender, EventArgs e)
        {
            //Lecturer lecturer = new Lecturer()
            //{
            //    Name = AddFormView.TitleInput.Text,
            //    Faculty = FacultyView.Faculty,
            //    Courses = new Collection<Course>(),
            //    Reviews =  new Collection<Review>()
            //};
            //DB.Instance.Lecturers.Add(lecturer);
            //DB.Instance.SaveChanges();
            //FacultyView.LecturerList.Items.Add(lecturer);
            //AddFormView.Close();
        }

        public void HandleAddStudyProgram(object sender, EventArgs e)
        {
            //StudyProgram program = new StudyProgram()
            //{
            //    Title = AddFormView.TitleInput.Text,
            //    Description = AddFormView.DescriptionInput.Text,
            //    Faculty = FacultyView.Faculty,
            //    Reviews = new Collection<Review>(),
            //    Courses = new Collection<Course>()
            //};
            //DB.Instance.StudyPrograms.Add(program);
            //DB.Instance.SaveChanges();
            //FacultyView.StudyProgramList.Items.Add(program);
            //AddFormView.Close();
        }

        private StatsData LoadStats(Faculty faculty)
        {
            var stats = StatsBuilder.BuildFacultyStats(faculty);
            StatsData statsData = new StatsData
            {
                ReviewCount = stats.review_count,
                OveralRating = stats.overal,
                StudyProgramCount = stats.study_program_count,
                Satisfaction = stats.satisfaction,
                AverageSalary = stats.salary,
                RelevantIndustryPercentage = stats.relevant_industry,
                LocationCount = stats.location_count,
                LecturerCount = stats.lecturer_count
            };

            return statsData;
        }
    }
}
