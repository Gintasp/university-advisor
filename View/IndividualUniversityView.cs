using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class IndividualUniversityView : Form
    {
        public AuthController AuthController { get; set; }
        public IndividualUniversityView()
        {
            InitializeComponent();
        }
        private void IndividualUniversityView_Load(object sender, EventArgs e)
        {
            AuthController.HandleLoadIndividualUniversityView(UniversityName);
        }

        private void Faculties_Click(object sender, EventArgs e)
        {
            AuthController.HandleFacultiesClicked();
        }

        private void PreviousForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthController.LoadPreviousFormIndividualUniversityView();
        }
    }
}
