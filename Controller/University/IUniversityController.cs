using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IUniversityController
    {
        UniversityView UniversityView { get; set; }
        void HandlePreviousButtonClick();
        void LoadFacultyData(University uni);
        void HandleFacultySelect(Faculty faculty, University uni);
    }
}