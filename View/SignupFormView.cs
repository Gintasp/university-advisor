using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Model;

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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AuthController.CloseSignupView();
        }
       
    }
}
