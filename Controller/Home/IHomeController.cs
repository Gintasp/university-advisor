using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IHomeController
    {
        HomeView HomeView { get; set; }
        void HandleAddUniversityClick();
        void LoadUniversityList();
        void HandleUniversitySelect(University uni);
    }
}
