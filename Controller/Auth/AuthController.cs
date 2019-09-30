using System.Windows.Forms;
using Advisor.View;
using Advisor.Model;
using Advisor.Service.Validator;
using Advisor.Service.Auth;

namespace Advisor.Controller
{
    public class AuthController : IAuthController
    {
        public ISignupDataValidator SignupDataValidator { get; set; }
        public ILoginDataValidator LoginDataValidator { get; set; }
        public SignupFormView SignupFormView { get; set; }
        public LoginFormView LoginFormView { get; set; }
        public HomeView HomeView { get; set; }
        public IHomeController HomeController { get; set; }
        public IPasswordEncoder PasswordEncoder { get; set; }

        public AuthController(
            ILoginDataValidator loginDataValidator,
            ISignupDataValidator signupDataValidator,
            IHomeController homeController,
            IPasswordEncoder passwordEncoder
        ) {
            LoginDataValidator = loginDataValidator;
            SignupDataValidator = signupDataValidator;
            HomeController = homeController;
            PasswordEncoder = passwordEncoder;
        }

        private bool AuthenticateUser(string email, string password)
        {
            //TODO: Authenticate user from DB

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
            if (AuthenticateUser(email, password))
            {
                LoginFormView.Hide();
                HomeView = new HomeView(HomeController);
                HomeView.ShowDialog();
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

            user.Password = PasswordEncoder.Encode(user.Password);
            DB.Instance.Users.Add(user);
            DB.Instance.SaveChanges();

            SignupFormView.Hide();
            LoginFormView.Show();

            return true;
        }
    }
}
