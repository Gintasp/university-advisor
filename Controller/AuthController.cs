using System.Windows.Forms;
using Advisor.View;
using Advisor.Model;
using Advisor.Validator;

namespace Advisor.Controller
{
    public class AuthController : IAuthController
    {
        public AuthController(
            ALoginFormView loginFormView,
            ASignupFormView signupFormView,
            AWhatUniversityView whatUniversityView,
            ILoginDataValidator loginDataValidator,
            ISignupDataValidator signupDataValidator
        ) {
            LoginFormView = loginFormView;
            SignupFormView = signupFormView;
            WhatUniversityView = whatUniversityView;
            LoginDataValidator = loginDataValidator;
            SignupDataValidator = signupDataValidator;
        }

        public ISignupDataValidator SignupDataValidator { get; set; }
        public ILoginDataValidator LoginDataValidator { get; set; }
        public ALoginFormView LoginFormView { get; set; }
        public AWhatUniversityView WhatUniversityView { get; set; }

        public ASignupFormView SignupFormView { get; set; }

        public bool AuthenticateUser(string email, string password)
        {
            return true;
        }

        public void LoadViews()
        {
            LoginFormView.AuthController = this;
            SignupFormView.AuthController = this;
            WhatUniversityView.AuthController = this;
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
            if (AuthenticateUser(email, password) == true)
            {
                LoginFormView.Hide();
                WhatUniversityView.ShowDialog();
            }
            return false;
        }

        public bool HandleSignup (User user, string passConfirm)
        {
            if (!SignupDataValidator.Validate(user, passConfirm))
            {
                MessageBox.Show(SignupDataValidator.GetSignupDataVadilatorErrorMessage());
                return false;
            }

            DB.Instance.Users.Add(user);
            DB.Instance.SaveChanges();

            SignupFormView.Hide();
            LoginFormView.Show();

            return true;
        }
        public void HandleAddUniversityClick()
        {
            MessageBox.Show(";))");
        }
        public void LoadUniversityList(ListBox listBox)
        {
            //add data from database
        }
    }
}
