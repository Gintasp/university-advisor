using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IUniversityController
    {
        UniversityView UniversityView { get; set; }
        void HandleFacultiesClick(University uni);
        void HandlePreviousButtonClick();
    }
}