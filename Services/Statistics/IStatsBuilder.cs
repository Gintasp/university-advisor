using Advisor.Models;

namespace Advisor.Services.Statistics
{
    public interface IStatsBuilder
    {
        dynamic BuildCourseStats(Course course);
        dynamic BuildLecturerStats(Lecturer lecturer);
        dynamic BuildStudyProgramStats(StudyProgram program);
        dynamic BuildFacultyStats(Faculty faculty);
        dynamic BuildUniversityStats(University uni);
    }
}
