using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class StudyProgramSelectView : Form
    {
        public IStudyProgramComparisonController ComparisonController { get; set; }
        public ComboBox UniversityList { get; set; }
        public ComboBox FacultyList { get; set; }
        public ComboBox StudyProgramList { get; set; }
        public StudyProgramSelectView(IStudyProgramComparisonController studyProgramComparisonController)
        {
            ComparisonController = studyProgramComparisonController;
            UniversityList = UniversitySelectBox;
            FacultyList = FacultySelectBox;
            StudyProgramList = StudyProgramSelectBox;
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            ComparisonController.LoadUniversities();
        }

        private void OnChooseButtonClick(object sender, EventArgs e)
        {
            StudyProgram prog = (StudyProgram)StudyProgramList.SelectedItem;
            ComparisonController.SelectedStudyProgram(prog);
            this.Close();
        }

        private void OnUniversitySelect(object sender, EventArgs e)
        {
            University uni = (University)UniversityList.SelectedItem;
            ComparisonController.LoadFaculties(uni);
        }

        private void OnFacultySelect(object sender, EventArgs e)
        {
            Faculty fac = (Faculty)FacultyList.SelectedItem;
            ComparisonController.LoadStudyPrograms(fac);
        }
    }
}
