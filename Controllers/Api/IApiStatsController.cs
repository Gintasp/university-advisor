namespace Advisor.Controllers
{
    public interface IApiStatsController
    {
        string Index();
        string UniversityStats(int id);
        string FacultyStats(int id);
        string StudyProgramStats(int id);
        string CourseStats(int id);
        string LecturerStats(int id);
    }
}
