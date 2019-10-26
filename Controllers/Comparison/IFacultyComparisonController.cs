using Advisor.Models;

namespace Advisor.Controllers
{
    public interface IFacultyComparisonController
    {
        void LoadUniversities();
        void LoadFaculties1();
        void LoadFaculties2();
        StatsData BuildFacultyStats(Faculty faculty);
    }
}
