namespace Advisor.Controllers.Api
{
    public interface IApiUniversityController
    {
        string StudyPrograms(int id);
        string Lecturers(int id);
    }
}