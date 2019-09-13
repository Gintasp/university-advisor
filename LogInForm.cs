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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        private void LogInForm_Load(object sender, EventArgs e)
        {
            ////sukuria useriu lista su info is failo
            LogIn.users.Clear();
            List<string> lines = File.ReadAllLines(Directory.GetCurrentDirectory().ToString() + "\\data.txt").ToList();
            while (lines.Count > 0)
            {
                LogIn.users.Add(new User(lines.ElementAt(0), lines.ElementAt(1), lines.ElementAt(2)));
                for (int i = 0; i < 3; i++)
                {
                    lines.RemoveAt(0);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //atidaro sign up forma
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm s = new SignUpForm();
            s.ShowDialog();
            this.Close();
        }

        //prijungia prie sistemos
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if(!(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)))
            {
                if (LogIn.Confirmation(email, password) == true) MessageBox.Show(";))");
            }
        }
    }
}
