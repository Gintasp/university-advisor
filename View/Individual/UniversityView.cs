using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class UniversityView : Form
    {
        public IUniversityController UniversityController { get; set; }
        public University University { get; set; }
        public ListBox Faculties { get; set; }

        public UniversityView(IUniversityController universityController, University uni)
        {
            UniversityController = universityController;
            University = uni;
            universityController.UniversityView = this;
            InitializeComponent();
            Faculties = FacultyListBox;
        }

        private void LoadUniversityData(object sender, EventArgs e)
        {
            UniversityTitleLabel.Text = University.Title;
            AboutSection.Text = University.Description;
            UniversityController.LoadFacultyData(University);
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UniversityController.HandlePreviousButtonClick();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnFacSelect(object sender, EventArgs e)
        {
            Faculty faculty = (Faculty)Faculties.SelectedItem;
            if(faculty != null)
            {
                UniversityController.HandleFacultySelect(faculty, University);
            }
        }

        private void OnAddFacultyClick(object sender, EventArgs e)
        {
            UniversityController.HandleAddFacultyClick();
        }
    }
}
