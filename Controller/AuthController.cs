using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Advisor.View;
using Advisor.Model;
using Advisor.Validator;

namespace Advisor.Controller
{
    public class AuthController
    {
        public AuthController(
            LoginFormView loginFormView,
            SignupFormView signupFormView,
            List<User> users,
            LoginDataValidator loginDataValidator,
            SignupDataValidator signupDataValidator
        ) {
            LoginFormView = loginFormView;
            SignupFormView = signupFormView;
            LoginDataValidator = loginDataValidator;
            SignupDataValidator = signupDataValidator;
            Users = users;
        }

        public SignupDataValidator SignupDataValidator { get; set; }
        public LoginDataValidator LoginDataValidator { get; set; }
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

        public bool HandleLogin (string email, string password)
        {
            if (!LoginDataValidator.Validate(email, password)) return false;
            if (AuthenticateUser(email, password) == true) MessageBox.Show(";))");

            return false;
        }

        public bool HandleSignup (User user, string passConfirm)
        {
            if (!SignupDataValidator.Validate(user, passConfirm))
            {
                MessageBox.Show(SignupDataValidator.GetSignupDataVadilatorErrorMessage());
                return false;
            }

            File.AppendAllLines(
                Directory.GetCurrentDirectory().ToString() + "\\data.txt",
                new string[] { user.Email, user.FirstName, user.LastName, user.Password }
            );
            Users.Add(user);
            SignupFormView.Hide();
            LoginFormView.Show();

            return true;
        }
    }
}
