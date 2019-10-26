using Advisor.Model;

namespace Advisor.Controllers
{
    public interface IAuthController
    {
        void CloseLoginView();
        void CloseSignupView();
        void HandleSignupLinkClick();
        bool HandleLogin(string email, string password);
        bool HandleSignup(User user, string passConfirm);
    }
}
