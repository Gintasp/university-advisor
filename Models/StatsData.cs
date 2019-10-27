namespace Advisor.Models
{
    public struct StatsData
    {
        public float Usefulness { get; set; }
        public float Satisfaction { get; set; }
        public float Difficulty { get; set; }
        public float OveralRating { get; set; }
        public float Interesting { get; set; }
        public float Theory { get; set; }
        public float Practice { get; set; }
        public float AverageSalary { get; set; }
        public int FacultyCount { get; set; }
        public int LecturerCount { get; set; }
        public int CourseCount { get; set; }
        public int ReviewCount { get; set; }
        public int StudyProgramCount { get; set; }
        public int RelevantIndustryPercentage { get; set; }
        public float Competence { get; set; }
        public float Strictness { get; set; }
        public float Delivery { get; set; }
        public float Personality { get; set; }
    }
}
