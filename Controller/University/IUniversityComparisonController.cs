using Advisor.View.Comparison;
using Advisor.Model;

namespace Advisor.Controller
{
    public interface IUniversityComparisonController
    {
       UniversityComparisonView UniversityComparisonView { get; set; }
        void LoadUniversityList();
        void HandlePreviousButtonClick(University uni);
        void LoadStats(University uni);
    }
}
