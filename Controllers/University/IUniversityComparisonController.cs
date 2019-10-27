using Advisor.Models;

namespace Advisor.Controllers
{
    public interface IUniversityComparisonController
    {
        void LoadUniversityList();
        void HandlePreviousButtonClick(University uni);
        void LoadStats(University uni);
    }
}
