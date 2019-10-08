using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class UniversityView : Form
    {
        public IUniversityController UniversityController { get; set; }
        public University University { get; set; }
        public ListBox FacultyList { get; set; }
        public StatsData StatsData { get; set; }

        public UniversityView(IUniversityController universityController)
        {
            UniversityController = universityController;
            universityController.UniversityView = this;
            InitializeComponent();
            FacultyList = FacultyListBox;
        }

        private void LoadUniversityData(object sender, EventArgs e)
        {
            UniversityController.LoadData();
            ShowStatsData();
            UniversityTitleLabel.Text = University.Title;
            AboutSection.Text = University.Description;
        }

        private void ShowStatsData()
        {
            SalaryVal.Text = StatsData.AverageSalary.ToString() + " €";
            OveralVal.Text = StatsData.OveralRating.ToString() + " / 10";
            FacultiesVal.Text = StatsData.FacultyCount.ToString();
            ReviewsVal.Text = StatsData.ReviewCount.ToString();
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UniversityController.HandlePreviousButtonClick();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnFacultySelect(object sender, EventArgs e)
        {
            Faculty faculty = (Faculty) FacultyList.SelectedItem;
            if (faculty != null)
            {
                UniversityController.HandleFacultySelect(faculty);
            }
        }

        private void OnAddFacultyClick(object sender, EventArgs e)
        {
            UniversityController.HandleAddFacultyClick();
        }

        private void OnComparisonButtonClick(object sender, EventArgs e)
        {
            UniversityController.HandleComparisonButtonClick();
        }
    }
}
