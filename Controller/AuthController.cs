using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Advisor
{
    public class AuthController
    {
        public AuthController (
            LoginFormView loginFormView,
            SignupFormView signupFormView,
            List<User> users
        ) {
            LoginFormView = loginFormView;
            SignupFormView = signupFormView;
            Users = users;
        }

        public LoginFormView LoginFormView { get; set; }

        public List<User> Users { get; set; }

        public SignupFormView SignupFormView { get; set; }

        public bool AuthenticateUser(string email, string password)
        {
            foreach (User userFromList in Users)
            {
                if (userFromList.Email.Equals(email) && userFromList.Password.Equals(password)) return true;
            }

            return false;
        }

        public void LoadViews()
        {
            LoginFormView.AuthController = this;
            SignupFormView.AuthController = this;
        }

        public void CloseLoginView()
        {
            LoginFormView.Close();
        }

        public void CloseSignupView()
        {
            SignupFormView.Close();
            LoginFormView.Show();
        }

        public void HandleSignupLinkClick()
        {
            LoginFormView.Hide();
            SignupFormView.ShowDialog();
        }

        public void HandleLogin (string email, string password)
        {
            if (!(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)))
            {
                if (this.AuthenticateUser(email, password) == true) MessageBox.Show(";))");
            }
        }

        public void HandleSignup (string email, string name, string pass, string passConfirm)
        {
            if (
                !(string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(name)
                || string.IsNullOrWhiteSpace(pass)
                || string.IsNullOrWhiteSpace(passConfirm)
                )
            ) {
                if (pass.Equals(passConfirm))
                {
                    File.AppendAllLines(Directory.GetCurrentDirectory().ToString() + "\\data.txt", new string[] { email, name, pass});
                    Users.Add(new User(email, name, pass));
                    SignupFormView.Hide();
                    LoginFormView.Show();
                }
            }
        }
    }
}
