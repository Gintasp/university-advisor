using System.Windows.Forms;
using Advisor.View;
using Advisor.Model;
using Advisor.Validator;

namespace Advisor.Controller
{
    public class AuthController : IAuthController
    {
        public AuthController(
            ILoginDataValidator loginDataValidator,
            ISignupDataValidator signupDataValidator
        ) {
            LoginDataValidator = loginDataValidator;
            SignupDataValidator = signupDataValidator;
        }

        public ISignupDataValidator SignupDataValidator { get; set; }
        public ILoginDataValidator LoginDataValidator { get; set; }
        public SignupFormView SignupFormView { get; set; }
        public LoginFormView LoginFormView { get; set; }

        public bool AuthenticateUser(string email, string password)
        {
            return true;
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
            SignupFormView = new SignupFormView(this);
            SignupFormView.ShowDialog();
        }

        public bool HandleLogin (string email, string password)
        {
            if (!LoginDataValidator.Validate(email, password)) return false;
            if (AuthenticateUser(email, password) == true)
            {
                LoginFormView.Hide();
                MessageBox.Show("Success!");
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
