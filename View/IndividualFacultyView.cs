using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class IndividualFacultyView : Form
    {
        public AuthController AuthController { get; set; }

        public IndividualFacultyView()
        {
            InitializeComponent();
        }

        private void IndividualFaculty_Load(object sender, EventArgs e)
        {
            //load StudyProgramList
            //add text to AboutSection

            AuthController.HandleLoadIndividualFacultyView(FacultyTitle);
        }

        private void BtnLecturers_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddStudyProgram_Click(object sender, EventArgs e)
        {

        }

        private void PreviousForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthController.LoadPreviousFormIndividualFacultyView();
        }
    }
}
