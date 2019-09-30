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
        }

        private void OnFacultyLoad(object sender, EventArgs e)
        {
            FacultyTitleLabel.Text = Faculty.Title;
            LoadStudyProgramData();
        }

        private void LoadStudyProgramData()
        {
            FacultyController.LoadStudyProgramData(StudyProgramList);
        }

        private void OnLecturersButtonClick(object sender, EventArgs e)
        {
            //TODO: Handle by displaying lecturers list/form
        }

        private void OnAddStudyProgramButtonClick(object sender, EventArgs e)
        {
            //TODO: Handle adding new study program
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyController.HandlePreviousButtonClick(University);
        }

        private void onStudyProgramSelect(object sender, EventArgs e)
        {
            StudyProgram selectedProgram = (StudyProgram) StudyProgramList.SelectedItem;
            if(selectedProgram != null)
            {
                FacultyController.HandleStudyProgramSelect(selectedProgram, Faculty, University);
            }
        }

        private void onFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
