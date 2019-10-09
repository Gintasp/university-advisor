using Advisor.Controller;
using Advisor.Model;
using System.Windows.Forms;

namespace Advisor.View.Comparison
{
    public partial class LecturerComparisonView : Form
    {
        public ILecturerComparisonController LecturerComparisonController { get; set; }
        public Lecturer Lecturer { get; set; }

        public LecturerComparisonView(ILecturerComparisonController lecturerComparisonController, Lecturer lec)
        {
            LecturerComparisonController = lecturerComparisonController;
            Lecturer = lec;
            lecturerComparisonController.LecturerComparisonView = this;
            InitializeComponent();
        }

        private void OnLecurerOneSelectClick(object sender, System.EventArgs e)
        {
            LecturerComparisonController.HandleLecturerOneChooseClick();
        }

        private void OnLecurerTwoSelectClick(object sender, System.EventArgs e)
        {
            LecturerComparisonController.HandleLecturerTwoChooseClick();
        }

        public void LoadLecturerOne(Lecturer lecturer, StatsData statsData)
        {
            ReviewCountLec1.Text = statsData.ReviewCount.ToString();
            LecturerTitle1.Text = lecturer.Name;
            RatingLec1.Text = statsData.OveralRating.ToString();
            CompetenceLec1.Text = statsData.Competence.ToString();
            StrictnessLec1.Text = statsData.Strictness.ToString();
            DeliveryLec1.Text = statsData.Delivery.ToString();
            PersonalityLec1.Text = statsData.Personality.ToString();
        }

        public void LoadLecturerTwo(Lecturer lecturer, StatsData statsData)
        {
            ReviewCountLec2.Text = statsData.ReviewCount.ToString();
            LecturerTitle2.Text = lecturer.Name;
            RatingLec2.Text = statsData.OveralRating.ToString();
            CompetenceLec2.Text = statsData.Competence.ToString();
            StrictnessLec2.Text = statsData.Strictness.ToString();
            DeliveryLec2.Text = statsData.Delivery.ToString();
            PersonalityLec2.Text = statsData.Personality.ToString();
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LecturerComparisonController.HandlePreviousButtonClick(Lecturer);
        }

        private void OnViewClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
