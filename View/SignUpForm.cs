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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e) 
        {

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            /*string email = txtEmail.Text;
            string name = txtName.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            if(!(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword)))
            {
                if (password.Equals(confirmPassword))
                {
                    //prideda nauja user i sistema
                    File.AppendAllLines(Directory.GetCurrentDirectory().ToString() + "\\data.txt", new string[] { email, name, password});
                    LogIn.users.Add(new User(email, name, password));
                    //persijungia i LogIn langa
       
                    this.Hide();
                    LogInForm log = new LogInForm();
                    log.ShowDialog();
                    this.Close();
                }
                else label5.Show();  
            }*/
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            LogInForm log = new LogInForm();
            log.ShowDialog();
            this.Close();*/
        }
    }
}
