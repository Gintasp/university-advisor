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

        public void LoadData(Faculty faculty)
        {
            FacultyView.StudyProgramList.Items.Clear();
            FacultyView.LecturerList.Items.Clear();
            List<StudyProgram> programs = faculty.StudyPrograms.ToList();
            List<Lecturer> lecturers = faculty.Lecturers.ToList();
            programs.ForEach(program => FacultyView.StudyProgramList.Items.Add(program));
            lecturers.ForEach(lecturer => FacultyView.LecturerList.Items.Add(lecturer));
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram, faculty, uni));
            StudyProgramView.Show();
        }

        public void HandleLecturerSelect(Lecturer lecturer, Faculty faculty, University university)
        {
            //TODO: Display lecturer form
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
                Faculty = FacultyView.Faculty
            };
            DB.Instance.StudyPrograms.Add(program);
            DB.Instance.SaveChanges();
            FacultyView.StudyProgramList.Items.Add(program);
            AddFormView.Close();
        }
    }
}
