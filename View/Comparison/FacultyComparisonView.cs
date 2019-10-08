using Advisor.Controller;
using Advisor.Model;
using System;
using System.Windows.Forms;

namespace Advisor.View.Comparison
{
    public partial class FacultyComparisonView : Form
    {
        public IFacultyComparisonController FacultyComparisonController { get; set; }
        public ComboBox UniversitySelectBox1 { get; set; }
        public ComboBox UniversitySelectBox2 { get; set; }
        public ComboBox FacultySelectBox1 { get; set; }
        public ComboBox FacultySelectBox2 { get; set; }
        public StatsData StatsData { get; set; }
        public FacultyComparisonView(IFacultyComparisonController facultyComparisonController)
        {
            FacultyComparisonController = facultyComparisonController;
            facultyComparisonController.FacultyComparisonView = this;
            InitializeComponent();
            UniversitySelectBox1 = UniversitySelectBoxFac1;
            UniversitySelectBox2 = UniversitySelectBoxFac2;
            FacultySelectBox1 = FacultySelectBoxFac1;
            FacultySelectBox2 = FacultySelectBoxFac2;
        }

        private void FacultyComparisonViewLoad(object sender, EventArgs e)
        {
            FacultyComparisonController.LoadUniversities();
        }

        private void OnUniversity1Select(object sender, EventArgs e)
        {
            FacultyComparisonController.LoadFaculties1();
        }

        private void OnUniversity2Select(object sender, EventArgs e)
        {
            FacultyComparisonController.LoadFaculties2();
        }

        private void OnFaculty1Select(object sender, EventArgs e)
        {
            StatsData = FacultyComparisonController.BuildFacultyStats((Faculty)FacultySelectBox1.SelectedItem);
            ReviewCountFac1.Text = StatsData.ReviewCount.ToString();
            RatingFac1.Text = StatsData.OveralRating.ToString() + " / 10";
            LevelOfSatisfactionFac1.Text = StatsData.Satisfaction.ToString() + " / 10";
            AverageSalaryFac1.Text = StatsData.AverageSalary.ToString() + " €";
            LecturerCountFac1.Text = StatsData.LecturerCount.ToString();
            StudyProgramCountFac1.Text = StatsData.StudyProgramCount.ToString();
            PercentOfWorkingGraduatesFac1.Text = StatsData.RelevantIndustryPercentage.ToString() + " %";
        }

        private void OnFaculty2Select(object sender, EventArgs e)
        {

        }
    }
}
