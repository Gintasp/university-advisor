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
        public StatsData StatsData { get; set; }

        public FacultyView(
            IFacultyController facultyController,
            University uni
        ) {
            FacultyController = facultyController;
            University = uni;
            FacultyController.FacultyView = this;
            InitializeComponent();
            StudyProgramList = StudyProgramListBox;
            LecturerList = LecturerListBox;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            FacultyController.LoadData();
            ShowStatsData();
            FacultyTitleLabel.Text = Faculty.Title;
            AboutSection.Text = Faculty.Description;
        }

        private void ShowStatsData()
        {
            SalaryVal.Text = StatsData.AverageSalary.ToString() + " €";
            DifficultyVal.Text = StatsData.Difficulty.ToString() + " / 10";
            SatisfactionVal.Text = StatsData.Satisfaction.ToString() + " / 10";
            OveralVal.Text = StatsData.OveralRating.ToString() + " / 10";
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

        private void OnAddLecturerLinkClick(object sender, EventArgs e)
        {
            FacultyController.HandleAddLecturerClick();
        }

        private void OnLecturerSelect(object sender, EventArgs e)
        {
            Lecturer lecturer = (Lecturer) LecturerListBox.SelectedItem;
            if (lecturer != null)
            {
                FacultyController.HandleLecturerSelect(lecturer);
            }
        }
    }
}
