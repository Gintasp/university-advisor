using Advisor.Controller;
using System;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class LoginFormView : Form
    {
        public IAuthController AuthController { get; set; }
        public LoginFormView(IAuthController authController)
        {
            AuthController = authController;
            authController.LoginFormView = this;
            InitializeComponent();
        }

        private void OnSignupButtonClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthController.HandleSignupLinkClick();
        }

        private void OnLoginButtonClick(object sender, EventArgs e)
        {
            AuthController.HandleLogin(txtEmail.Text, txtPassword.Text);
        }
    }
}
