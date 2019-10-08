using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View.Comparison
{
    public partial class UniversityComparisonView : Form
    {
        public IUniversityComparisonController UniversityComparisonController { get; set; }
        public University University { get; set; }
        public StatsData StatsData { get; set; }
        public ComboBox University1ComboBox { get; set; }
        public ComboBox University2ComboBox { get; set; }
        public UniversityComparisonView(IUniversityComparisonController universityComparisonController, University uni)
        {
            UniversityComparisonController = universityComparisonController;
            University = uni;
            universityComparisonController.UniversityComparisonView = this;
            InitializeComponent();
            University1ComboBox = UniversitySelectBox1;
            University2ComboBox = UniversitySelectBox2;
        }

        private void OnFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UniversityComparisonController.HandlePreviousButtonClick(University);
        }

        private void LoadUniversityList(object sender, System.EventArgs e)
        {
            UniversityComparisonController.LoadUniversityList();
        }

        private void OnUniversity1Select(object sender, System.EventArgs e)
        {
            University uni = (University)University1ComboBox.SelectedItem;
            UniversityComparisonController.LoadStats(uni);
            UniversityTitle1.Text = uni.ToString();
            ReviewCountUni1.Text = StatsData.ReviewCount.ToString();
            RatingUni1.Text = StatsData.OveralRating.ToString() + " / 10";
            LevelOfSatisfactionUni1.Text = StatsData.Satisfaction.ToString() + " / 10";
            AverageSalaryUni1.Text = StatsData.AverageSalary.ToString() + " €";
            FacultyCountUni1.Text = StatsData.FacultyCount.ToString();
            StudyProgramCountUni1.Text = StatsData.StudyProgramCount.ToString();
            PercentOfWorkingGraduatesUni1.Text = StatsData.RelevantIndustryPercentage.ToString() + " %";

        }

        private void OnUniversity2Select(object sender, System.EventArgs e)
        {
            University uni = (University)University2ComboBox.SelectedItem;
            UniversityComparisonController.LoadStats(uni);
            UniversityTitle2.Text = uni.ToString();
            ReviewCountUni2.Text = StatsData.ReviewCount.ToString();
            RatingUni2.Text = StatsData.OveralRating.ToString() + " / 10";
            LevelOfSatisfactionUni2.Text = StatsData.Satisfaction.ToString() + " / 10";
            AverageSalaryUni2.Text = StatsData.AverageSalary.ToString() + " €";
            FacultyCountUni2.Text = StatsData.FacultyCount.ToString();
            StudyProgramCountUni2.Text = StatsData.StudyProgramCount.ToString();
            PercentOfWorkingGraduatesUni2.Text = StatsData.RelevantIndustryPercentage.ToString() + " %";
        }
    }
}
