using System;
using System.Drawing;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class FacultyListView : Form
    {
        public University University { get; set; }
        public IFacultyListController FacultyListController { get; set; }

        public FacultyListView(IFacultyListController facultyListController, University uni)
        {
            University = uni;
            FacultyListController = facultyListController;
            FacultyListController.FacultyListView = this;
            InitializeComponent();
        }

        private void FacultiesListView_Load(object sender, EventArgs e)
        {
            FacultyListController.LoadFacultyList(FacultiesListBox, University);
        }

        private void BtnAddFaculty_Click(object sender, EventArgs e)
        {
            //TODO: Add functionality to add new Faculty
        }

        private void OnSearchInputEnter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search")
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

        private void OnPreviousButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FacultyListController.HandlePreviousButtonClick();
        }

        private void OnFacultySelect(object sender, EventArgs e)
        {
            string facultyTitle = FacultiesListBox.GetItemText(FacultiesListBox.SelectedItem);
            FacultyListController.HandleFacultySelect(facultyTitle);
        }
    }
}
