using System;
using System.Drawing;

namespace Advisor.View
{
    public partial class WhatUniversityView : AWhatUniversityView
    {
        public WhatUniversityView()
        {
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
            AuthController.HandleAddUniversityClick();
        }

        private void WhatUniversity_Load(object sender, EventArgs e)
        {
            AuthController.LoadUniversityList(UniversityList);
        }
    }
}
