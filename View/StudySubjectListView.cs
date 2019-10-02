using Advisor.Controller;
using Advisor.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class StudySubjectListView : Form
    {
        public IStudySubjectListController StudySubjectListController { get; set; }
        public ListBox StudySubjectList { get; set; }
        public StudySubjectListView(IStudySubjectListController studySubjectListController)
        {
            StudySubjectListController = studySubjectListController;
            StudySubjectListController.StudySubjectListView = this;
            InitializeComponent();
            StudySubjectList = StudySubjectData;
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
            StudySubjectListController.LoadStudySubjectData();
        }

        private void OnPreviousFormButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudySubjectListController.HandlePreviousFormButtonClick();
        }

        private void SelectedSubject(object sender, EventArgs e)
        {
            StudySubject subject = (StudySubject) StudySubjectData.SelectedItem;
            StudySubjectListController.HandleSelectedSubject(subject);
        }

        private void onFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
