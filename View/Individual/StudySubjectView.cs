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
    public partial class StudySubjectView : Form
    {
        public IStudySubjectController StudySubjectController { get; set; }
        
        public StudySubjectView(IStudySubjectController studySubjectController)
        {
            StudySubjectController = studySubjectController;
            StudySubjectController.StudySubjectView = this;
            InitializeComponent();
        }
        private void StudySubjectView_Load(object sender, EventArgs e)
        {
            StudySubjectController.LoadReviews(Reviews);
        }
        private void PreviousForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudySubjectController.HandlePreviousClicked();
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
