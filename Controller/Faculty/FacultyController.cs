using Advisor.Model;
using Advisor.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    public class FacultyController : IFacultyController
    {
        public FacultyView FacultyView { get; set; }
        public UniversityView UniversityView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }
        public AddFormView AddFormView { get; set; }

        public void HandlePreviousButtonClick(University uni)
        {
            FacultyView.Hide();
            UniversityView = new UniversityView(new UniversityController(this), uni);
            UniversityView.Show();
        }

        public void LoadStudyProgramData(Faculty faculty)
        {
            FacultyView.StudyProgramList.Items.Clear();
            List<StudyProgram> programs = DB.Instance.StudyPrograms.Where(p => p.Faculty.Id == faculty.Id).ToList();
            foreach (StudyProgram studyProgram in programs)
            {
                FacultyView.StudyProgramList.Items.Add(studyProgram);
            }
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram, faculty, uni));
            StudyProgramView.Show();
        }

        public void HandleLecturersButtonClick(Faculty faculty)
        {
            FacultyView.Hide();
            LecturerListView LecturerListView = new LecturerListView(new LecturerListController(faculty));
            LecturerListView.Show();
        }

        public void HandleAddStudyProgramClick()
        {
            AddFormView = new AddFormView();
            AddFormView.AddButtonClicked += HandleAddStudyProgram;
            AddFormView.TitleLabel.Text = "Add study program";
            AddFormView.ShowDialog();
        }

        public void HandleAddStudyProgram(object sender, EventArgs e)
        {
            StudyProgram program = new StudyProgram()
            {
                Title = AddFormView.TitleInput.Text,
                Description = AddFormView.DescriptionInput.Text,
                Faculty = FacultyView.Faculty
            };
            DB.Instance.StudyPrograms.Add(program);
            DB.Instance.SaveChanges();
            FacultyView.StudyProgramList.Items.Add(program);
            AddFormView.Close();
        }
    }
}
