using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class SignupFormView : Form
    {
        public AuthController AuthController { get; set; }

        public SignupFormView()
        {
            InitializeComponent();
        }

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
