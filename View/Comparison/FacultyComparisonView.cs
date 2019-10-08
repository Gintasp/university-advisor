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
    }
}
