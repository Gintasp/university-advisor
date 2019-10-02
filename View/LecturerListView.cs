using System;
using System.Drawing;
using System.Windows.Forms;
using Advisor.Controller;

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
            LecturerList = LecturerData;
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

        private void OnAddLecturerButtonClick(object sender, EventArgs e)
        {
            //TODO: Implement handling of new lecturer creation
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
            string title = LecturerData.SelectedItem.ToString();
            LecturerListController.HandleSelectedLecturer(title);
        }
    }
}
