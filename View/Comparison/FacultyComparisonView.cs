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
        public FacultyComparisonView(IFacultyComparisonController facultyComparisonController)
        {
            FacultyComparisonController = facultyComparisonController;
            facultyComparisonController.FacultyComparisonView = this;
            InitializeComponent();
            UniversitySelectBox1 = UniversitySelectBoxFac1;
            UniversitySelectBox2 = UniversitySelectBoxFac2;
        }

        private void FacultyComparisonViewLoad(object sender, EventArgs e)
        {
            FacultyComparisonController.LoadUniversities();
        }
    }
}
