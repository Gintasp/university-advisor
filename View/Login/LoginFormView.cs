using System;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class LoginFormView : ALoginFormView
    {
        public LoginFormView()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthController.HandleSignupLinkClick();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            AuthController.HandleLogin(txtEmail.Text, txtPassword.Text);
        }
    }
}
