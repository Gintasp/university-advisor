using System;
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
