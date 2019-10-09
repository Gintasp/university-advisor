using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class StudyProgramComparisonView : Form
    {
        public IStudyProgramComparisonController ComparisonController { get; set; }

        public StudyProgramComparisonView(IStudyProgramComparisonController studyProgramComparisonController)
        {
            ComparisonController = studyProgramComparisonController;
            ComparisonController.ComparisonView = this;
            InitializeComponent();
        }

        public void ShowFirstProgramStatsData(StudyProgram program, StatsData data)
        {
            ProgramTitle1.Text = program.Title;
            ReviewCount1.Text = data.ReviewCount.ToString();
            Rating1.Text = data.OveralRating + "/10";
            Satisfaction1.Text = data.Satisfaction + "/10";
            Salary1.Text = data.AverageSalary + "eur";
            CourseCount1.Text = data.CourseCount.ToString();
            WorkingGraduates1.Text = data.RelevantIndustryPercentage + "%";
        }

        public void ShowSecondProgramStatsData(StudyProgram program, StatsData data)
        {
            ProgramTitle2.Text = program.Title;
            ReviewCount2.Text = data.ReviewCount.ToString();
            Rating2.Text = data.OveralRating + "/10";
            Satisfaction2.Text = data.Satisfaction + "/10";
            Salary2.Text = data.AverageSalary + "eur";
            CourseCount2.Text = data.CourseCount.ToString();
            WorkingGraduates2.Text = data.RelevantIndustryPercentage + "%";
        }

        private void OnSelectProgramOneClick(object sender, System.EventArgs e)
        {
            ComparisonController.HandleProgramOneSelectClick();
        }

        private void OnSelectProgramTwoClick(object sender, System.EventArgs e)
        {
            ComparisonController.HandleProgramTwoSelectClick();
        }

        private void OnPreviousFormLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComparisonController.HandlePreviousFormClick();
        }
    }
}
