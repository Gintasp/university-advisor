using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class FacultyView : Form
    {
        public IFacultyController FacultyController { get; set; }
        public Faculty Faculty { get; set; }
        public University University { get; set; }
        public ListBox StudyProgramList { get; set; }
        public ListBox LecturerList { get; set; }

        public FacultyView(
            IFacultyController facultyController,
            Faculty faculty,
            University uni
        ) {
            FacultyController = facultyController;
            Faculty = faculty;
            University = uni;
            FacultyController.FacultyView = this;
            InitializeComponent();
            StudyProgramList = StudyProgramListBox;
            LecturerList = LecturerListBox;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            FacultyTitleLabel.Text = Faculty.Title;
            AboutSection.Text = Faculty.Description;
            FacultyController.LoadData(Faculty);
        }

        private void OnAddStudyProgramButtonClick(object sender, EventArgs e)
        {
            //TODO: Handle adding new study program
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyController.HandlePreviousButtonClick(University);
        }

        private void OnStudyProgramSelect(object sender, EventArgs e)
        {
            StudyProgram selectedProgram = (StudyProgram) StudyProgramListBox.SelectedItem;
            if(selectedProgram != null)
            {
                FacultyController.HandleStudyProgramSelect(selectedProgram, Faculty, University);
            }
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnAddLecturerButtonClick(object sender, EventArgs e)
        {
            //TODO: Handle adding lecturers
        }

        private void OnLecturerSelect(object sender, EventArgs e)
        {
            Lecturer lecturer = (Lecturer) LecturerListBox.SelectedItem;
            if (lecturer != null)
            {
                FacultyController.HandleLecturerSelect(lecturer, Faculty, University);
            }
        }
    }
}
