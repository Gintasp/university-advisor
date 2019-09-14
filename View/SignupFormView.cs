using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advisor
{
    public partial class SignupFormView : Form
    {
        public SignupFormView()
        {
            InitializeComponent();
        }

        public AuthController AuthController { get; set; }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            AuthController.HandleSignup(txtEmail.Text, txtName.Text, txtPassword.Text, txtConfirmPassword.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AuthController.CloseSignupView();
        }
    }
}
