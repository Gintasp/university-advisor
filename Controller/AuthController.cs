using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Advisor.View;
using Advisor.Model;
using Advisor.Service;

namespace Advisor.Controller
{
    public class AuthController
    {
        public AuthController(
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

        public bool HandleLogin (string email, string password, LoginDataValidator validator)
        {
            if (!validator.Validate(email, password)) return false;
            if (AuthenticateUser(email, password) == true) MessageBox.Show(";))");

            return false;
        }

        public bool HandleSignup (User user, string passConfirm, SignupDataValidator validator)
        {
            if (!validator.Validate(user, passConfirm)) return false;

            File.AppendAllLines(
                Directory.GetCurrentDirectory().ToString() + "\\data.txt",
                new string[] { user.Email, user.Name, user.Password }
            );
            Users.Add(user);
            SignupFormView.Hide();
            LoginFormView.Show();

            return true;
        }
    }
}
