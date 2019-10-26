using Advisor.Model;
using Advisor.Service.Validator;
using Advisor.Service.Auth;

namespace Advisor.Controllers
{
    public class AuthController : IAuthController
    {
        public ISignupDataValidator SignupDataValidator { get; set; }
        public ILoginDataValidator LoginDataValidator { get; set; }
        public IPasswordEncoder PasswordEncoder { get; set; }

        public AuthController(
            ILoginDataValidator loginDataValidator,
            ISignupDataValidator signupDataValidator,
            IPasswordEncoder passwordEncoder
        ) {
            LoginDataValidator = loginDataValidator;
            SignupDataValidator = signupDataValidator;
            PasswordEncoder = passwordEncoder;
        }

        private bool AuthenticateUser(string email, string password)
        {
            //User user = DB.Instance.Users.Where(u => u.Email == email).SingleOrDefault();
            //if(user == null)
            //{
            //    return false;
            //}

            //return PasswordEncoder.Verify(password, user.Password);
            return false;
        }

        public void CloseLoginView()
        {
            //LoginFormView.Close();
        }

        public void CloseSignupView()
        {
            //SignupFormView.Close();
            //LoginFormView.Show();
        }

        public void HandleSignupLinkClick()
        {
            //LoginFormView.Hide();
            //SignupFormView = new SignupFormView(this);
            //SignupFormView.ShowDialog();
        }

        public bool HandleLogin (string email, string password)
        {
            //if (!LoginDataValidator.Validate(email, password)) return false;
            //if (AuthenticateUser(email, password))
            //{
            //    SessionStorage.Instance.User = DB.Instance.Users.Where(u => u.Email.Equals(email)).SingleOrDefault();
            //    LoginFormView.Hide();
            //    HomeView = new HomeView(new HomeController());
            //    HomeView.ShowDialog();
            //}

            return false;
        }

        public bool HandleSignup (User user, string passConfirm)
        {
            //if (!SignupDataValidator.Validate(user, passConfirm))
            //{
            //    MessageBox.Show(SignupDataValidator.GetSignupDataValidatorErrorMessage());

            //    return false;
            //}

            //user.Password = PasswordEncoder.Encode(user.Password);
            //DB.Instance.Users.Add(user);
            //DB.Instance.SaveChanges();

            //SignupFormView.Hide();
            //LoginFormView.Show();

            return true;
        }
    }
}
