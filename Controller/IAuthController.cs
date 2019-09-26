using Advisor.Model;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IAuthController
    {
        bool AuthenticateUser(string email, string password);
        void LoadViews();
        void CloseLoginView();
        void CloseSignupView();
        void HandleSignupLinkClick();
        bool HandleLogin(string email, string password);
        bool HandleSignup(User user, string passConfirm);
        void HandleAddUniversityClick();
        void LoadUniversityList(ListBox listBox);
    }
}
