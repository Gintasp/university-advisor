using System;
using System.Drawing;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class StudySubjectListView : Form
    {
        public StudySubjectListView()
        {
            InitializeComponent();
        }

        private void OnSearchInputEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void OnSearchInputLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void OnAddStudySubjectButtonClick(object sender, EventArgs e)
        {
            //TODO: Add handler
        }

        private void LoadStudySubjectData(object sender, EventArgs e)
        {
            //TODO: Load StudySubject data from db
        }

        private void OnPreviousFormButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Go back to study program form
        }
    }
}
