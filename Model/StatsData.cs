namespace Advisor.Model
{
    public struct StatsData
    {
        public float Usefulness { get; set; }
        public float Satisfaction { get; set; }
        public float Difficulty { get; set; }
        public float OveralRating { get; set; }
        public float Theory { get; set; }
        public float Practice { get; set; }
        public float AverageSalary { get; set; }
        public int FacultyCount { get; set; }
        public int LecturerCount { get; set; }
        public int CourseCount { get; set; }
        public int ReviewCount { get; set; }
        public int RelevantIndustryPercentage { get; set; }
    }
}
