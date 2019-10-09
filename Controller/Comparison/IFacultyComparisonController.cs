using Advisor.Model;
using Advisor.View.Comparison;

namespace Advisor.Controller
{
    public interface IFacultyComparisonController
    {
        FacultyComparisonView FacultyComparisonView { get; set; }
        void LoadUniversities();
        void LoadFaculties1();
        void LoadFaculties2();
        StatsData BuildFacultyStats(Faculty faculty);
    }
}
