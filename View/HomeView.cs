using Advisor.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class HomeView : Form
    {
        public IHomeController HomeController { get; set; }
        public HomeView(IHomeController homeController)
        {
            HomeController = homeController;
            homeController.HomeView = this;
            InitializeComponent();
        }

        private void PrimaryTextDeletion(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void SetPrimaryText(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search";
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void AddUniversityClicked(object sender, EventArgs e)
        {
            HomeController.HandleAddUniversityClick();
        }

        private void WhatUniversity_Load(object sender, EventArgs e)
        {
            HomeController.LoadUniversityList(UniversityList);
        }

        private void SelectedUniversity(object sender, EventArgs e)
        {
            AuthController.HandleSelectedUniversity(UniversityList.GetItemText(UniversityList.SelectedItem));
        }
    }
}
