using Advisor.Model;
using Advisor.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    public class CourseListController : ICourseListController
    {
        public CourseListView CourseListView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public CourseView CourseView { get; set; }
        public AddFormView AddFormView { get; set; }

        public CourseListController(StudyProgram studyProgram)
        {
            StudyProgram = studyProgram;
        }

        public void HandleAddCourseButtonClick()
        {
            AddFormView = new AddFormView();
            AddFormView.TitleLabel.Text = "Add new course";
            AddFormView.DescriptionInput.Visible = false;
            AddFormView.DescriptionLabel.Visible = false;
            AddFormView.AddButtonClicked += HandleAddCourse;
            AddFormView.ShowDialog();
        }

        public void HandleAddCourse(object sender, EventArgs e)
        {
            Course course = new Course()
            {
                Title = AddFormView.TitleInput.Text,
                StudyProgram = StudyProgram
            };
            DB.Instance.Courses.Add(course);
            DB.Instance.SaveChanges();
            CourseListView.CourseList.Items.Add(course);
            AddFormView.Close();
        }

        public void LoadCourseData()
        {
            List<Course> courses = DB.Instance.Courses.Where(s => s.StudyProgram.Id == StudyProgram.Id).ToList();
            foreach(Course course in courses)
            {
                CourseListView.CourseList.Items.Add(course);
            }
        }
        public void HandleSelectedCourse(Course course)
        {
            CourseListView.Hide();
            CourseView = new CourseView(new CourseController(StudyProgram, course), course);
            CourseView.Show();
        }

        public void HandlePreviousFormButtonClick()
        {
            Faculty fac = GetFacultyByStudyProgram(StudyProgram);
            University uni = GetUniversityByFaculty(fac);

            CourseListView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(StudyProgram, fac, uni));
            StudyProgramView.Show();
        }

        private University GetUniversityByFaculty(Faculty fac)
        {
            return DB.Instance.Universities.Join(
                DB.Instance.Faculties,
                u => u.Id,
                f => f.University.Id,
                (u, f) => new { University = u, Faculty = f }
            )
            .Where(u => u.University.Id == fac.University.Id)
            .Select(u => u.University)
            .Distinct()
            .SingleOrDefault();
        }

        private Faculty GetFacultyByStudyProgram(StudyProgram program)
        {
            return DB.Instance.Faculties.Join(
                DB.Instance.StudyPrograms,
                f => f.Id,
                p => p.Faculty.Id,
                (f, p) => new { Faculty = f, StudyProgram = p }
            )
            .Where(p => p.StudyProgram.Id == program.Id)
            .Select(f => f.Faculty)
            .SingleOrDefault();
        }
    }
}
