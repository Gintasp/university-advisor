using Advisor.Controller;
using Advisor.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class HomeView : Form
    {
        public ListBox UniversityList { get; set; }
        public IHomeController HomeController { get; set; }
        public TextBox SearchBox { get; set; }
        public HomeView(IHomeController homeController)
        {
            HomeController = homeController;
            homeController.HomeView = this;
            InitializeComponent();
            UniversityList = UniversityData;
            SearchBox = searchBox;
        }

        private void PrimaryTextDeletion(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Search")
            {
                SearchBox.Text = "";
                SearchBox.ForeColor = Color.Black;
            }
        }

        private void LoadUniversityList(object sender, EventArgs e)
        {
           HomeController.LoadUniversityList();
        }

        private void SelectedUniversity(object sender, EventArgs e)
        {
            University uni = (University) UniversityData.SelectedItem;
            HomeController.HandleUniversitySelect(uni);
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OnAddUniversityLinkClick(object sender, EventArgs e)
        {
            HomeController.HandleAddUniversityClick();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
          HomeController.HandleSearchBox();
        }
        private void SetPrimaryText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                SearchBox.Text = "Search";
                SearchBox.ForeColor = Color.Silver;
                HomeController.LoadUniversityList();
            }
        }


    }
}
