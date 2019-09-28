using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

namespace Advisor.View
{
    public partial class SignupFormView : Form
    {
        public IAuthController AuthController { get; set; }
        public SignupFormView(IAuthController authController)
        {
            AuthController = authController;
            authController.SignupFormView = this;
            InitializeComponent();
        }

        public SignupFormView()
        {
            InitializeComponent();
        }

        private void OnSignupButtonClick(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                User user = new User(txtEmail.Text, txtName.Text, txtPassword.Text);
                AuthController.HandleSignup(user, txtConfirmPassword.Text);
            }
            else
            {
                MessageBox.Show("The password and confirmation password do not match.");
            }
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            AuthController.CloseSignupView();
        }

        private void onFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
