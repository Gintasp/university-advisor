using System;
using Advisor.Controller;
using System.Drawing;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class WhatUniversity : Form
    {
        public WhatUniversity()
        {
            InitializeComponent();
        }

        public AuthController AuthController { get; set; }

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
            AuthController.HandleAddUniversityClick();
        }

        private void WhatUniversity_Load(object sender, EventArgs e)
        {
            AuthController.LoadUniversityList(UniversityList);
        }
    }
}
