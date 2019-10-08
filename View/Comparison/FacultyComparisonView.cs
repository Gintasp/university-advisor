using Advisor.Controller;
using Advisor.Model;
using System;
using System.Windows.Forms;

namespace Advisor.View.Comparison
{
    public partial class FacultyComparisonView : Form
    {
        public IFacultyComparisonController FacultyComparisonController { get; set; }
        public FacultyComparisonView(IFacultyComparisonController facultyComparisonController)
        {
            FacultyComparisonController = facultyComparisonController;
            facultyComparisonController.FacultyComparisonView = this;
            InitializeComponent();
        }
    }
}
