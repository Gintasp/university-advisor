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
    public partial class LoginFormView : Form
    {
        public LoginFormView()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.LoginController.CloseView();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm s = new SignUpForm();
            s.ShowDialog();
            this.Close();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LoginController.HandleLogin(txtEmail.Text, txtPassword.Text);
        }

        public LoginController LoginController { get; set; }
    }
}
