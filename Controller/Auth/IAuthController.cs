using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IAuthController
    {
        LoginFormView LoginFormView { get; set; }
        SignupFormView SignupFormView { get; set; }
        bool AuthenticateUser(string email, string password);
        void CloseLoginView();
        void CloseSignupView();
        void HandleSignupLinkClick();
        bool HandleLogin(string email, string password);
        bool HandleSignup(User user, string passConfirm);
    }
}
