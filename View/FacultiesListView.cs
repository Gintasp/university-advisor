using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class FacultiesListView : Form
    {
        public FacultiesListView()
        {
            InitializeComponent();
        }
        private void FacultiesListView_Load(object sender, EventArgs e)
        {
            //load FacultiesList
        }

        private void BtnAddFaculty_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }

        }
    }
}
