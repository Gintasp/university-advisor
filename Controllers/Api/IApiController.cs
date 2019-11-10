namespace Advisor.Controllers
{
    public interface IApiController
    {
        string Index();
        string UniversityStats(int id);
        string FacultyStats(int id);
        string StudyProgramStats(int id);
        string CourseStats(int id);
        string LecturerStats(int id);
    }
}
