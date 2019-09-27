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
    public partial class StudySubjectListView : Form
    {
        public StudySubjectListView()
        {
            InitializeComponent();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void BtnAddStudySubject_Click(object sender, EventArgs e)
        {

        }

        private void StudySubjectListView_Load(object sender, EventArgs e)
        {
            // load StudySubjectList
        }

        private void PreviousForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //go back to StudyProgramView
        }
    }
}
