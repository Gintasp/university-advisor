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
        }

        private void OnFacultyLoad(object sender, EventArgs e)
        {
            FacultyTitleLabel.Text = Faculty.Title;
            AboutSection.Text = Faculty.Description;
            FacultyController.LoadStudyProgramData(Faculty);
        }

        private void OnLecturersButtonClick(object sender, EventArgs e)
        {
            FacultyController.HandleLecturersButtonClick(Faculty);
        }

        private void OnAddStudyProgramLinkClick(object sender, EventArgs e)
        {
            FacultyController.HandleAddStudyProgramClick();
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
    }
}
