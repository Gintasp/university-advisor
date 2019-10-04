using System;
using System.Drawing;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class LecturerListView : Form
    {
        public ILecturerListController LecturerListController { get; set; }
        public ListBox LecturerList { get; set; }
        public LecturerListView(ILecturerListController lecturerListController)
        {
            LecturerListController = lecturerListController;
            LecturerListController.LecturerListView = this;
            InitializeComponent();
            LecturerList = LecturerData;
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

        private void OnAddLecturerLinkClick(object sender, EventArgs e)
        {
            LecturerListController.HandleAddLecturerButtonClick();
        }

        private void LoadLecturerData(object sender, EventArgs e)
        {
            LecturerListController.LoadLecturerData();
        }

        private void OnPreviousFormButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LecturerListController.HandlePreviousFormButtonClick();
        }

        private void SelectedLecturer(object sender, EventArgs e)
        {
            Lecturer lecturer = (Lecturer) LecturerData.SelectedItem;
            if (lecturer != null)
            {
                LecturerListController.HandleSelectedLecturer(lecturer);
            }
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
