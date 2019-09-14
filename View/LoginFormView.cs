using System;
using System.Windows.Forms;
using Advisor.Controller;
using Advisor.Service;

namespace Advisor.View
{
    public partial class LoginFormView : Form
    {
        public AuthController AuthController { get; set; }

        public LoginFormView()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AuthController.CloseLoginView();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthController.HandleSignupLinkClick();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            AuthController.HandleLogin(txtEmail.Text, txtPassword.Text, new LoginDataValidator());
        }
    }
}
