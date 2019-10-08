using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class StudyProgramComparisonView : Form
    {
        public IStudyProgramComparisonController ComparisonController { get; set; }
        public StatsData FirstProgramData { get; set; }
        public StatsData SecondProgramData { get; set; }
        public StudyProgramComparisonView(IStudyProgramComparisonController studyProgramComparisonController)
        {
            ComparisonController = studyProgramComparisonController;
            InitializeComponent();
        }

        private void OnSelectProgramClick(object sender, System.EventArgs e)
        {
            Button SenderButton = (Button)sender;
            bool isItSecondButton = false;

            if(SenderButton.Name == "StudyProgram2")
            {
                isItSecondButton = true;
            }

            ComparisonController.HandleProgramSelectClick(isItSecondButton);
        }

        private void OnFormLoad(object sender, System.EventArgs e)
        {
            ComparisonController.UpdateData();
        }

        public void ShowFirstProgramStatsData()
        {
            ReviewCount1.Text = FirstProgramData.ReviewCount.ToString();
            Rating1.Text = FirstProgramData.OveralRating + "/10";
            Satisfaction1.Text = FirstProgramData.Satisfaction + "/10";
            Salary1.Text = FirstProgramData.AverageSalary + "eur";
            CourseCount1.Text = FirstProgramData.CourseCount.ToString();
            WorkingGraduates1.Text = FirstProgramData.RelevantIndustryPercentage + "%";
        }

        public void ShowSecondProgramStatsData()
        {
            ReviewCount2.Text = SecondProgramData.ReviewCount.ToString();
            Rating2.Text = SecondProgramData.OveralRating + "/10";
            Satisfaction2.Text = SecondProgramData.Satisfaction + "/10";
            Salary2.Text = SecondProgramData.AverageSalary + "eur";
            CourseCount2.Text = SecondProgramData.CourseCount.ToString();
            WorkingGraduates2.Text = SecondProgramData.RelevantIndustryPercentage + "%";
        }
    }
}
