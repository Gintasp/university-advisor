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
        public UniversityView(IUniversityController universityController, University uni)
        {
            UniversityController = universityController;
            University = uni;
            universityController.UniversityView = this;
            InitializeComponent();
        }

        private void LoadUniversityTitle(object sender, EventArgs e)
        {
            UniversityTitleLabel.Text = University.Title;
        }

        private void OnFacultiesButtonClick(object sender, EventArgs e)
        {
            UniversityController.HandleFacultiesClick(University);
        }

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UniversityController.HandlePreviousButtonClick();
        }
    }
}
