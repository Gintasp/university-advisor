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

namespace Advisor.View.Comparison
{
    public partial class LecturerComparisonView : Form
    {
        public ILecturerController LecturerController { get; set; }
        public LecturerComparisonView(LecturerController lecturerController)
        {
            LecturerController = lecturerController;
            InitializeComponent();

        }

        private void Lecturer1_Click(object sender, EventArgs e)
        {
            LecturerController.DisplayPopup();
        }

        private void Lecturer2_Click(object sender, EventArgs e)
        {
            LecturerController.DisplayPopup();
        }
    }
}
