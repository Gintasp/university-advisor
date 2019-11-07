using Newtonsoft.Json;

namespace Advisor.Models
{
    public struct StatsData
    {
        [JsonProperty(PropertyName = "usefulness")]
        public float Usefulness { get; set; }
        [JsonProperty(PropertyName = "satisfaction")]
        public float Satisfaction { get; set; }
        [JsonProperty(PropertyName = "difficulty")]
        public float Difficulty { get; set; }
        [JsonProperty(PropertyName = "overal")]
        public float OveralRating { get; set; }
        [JsonProperty(PropertyName = "interesting")]
        public float Interesting { get; set; }
        [JsonProperty(PropertyName = "theory")]
        public float Theory { get; set; }
        [JsonProperty(PropertyName = "practice")]
        public float Practice { get; set; }
        [JsonProperty(PropertyName = "salary")]
        public float AverageSalary { get; set; }
        [JsonProperty(PropertyName = "faculty_count")]
        public int FacultyCount { get; set; }
        [JsonProperty(PropertyName = "lecturer_count")]
        public int LecturerCount { get; set; }
        [JsonProperty(PropertyName = "dormitory_count")]
        public int DormitoryCount { get; set; }
        [JsonProperty(PropertyName = "course_count")]
        public int CourseCount { get; set; }
        [JsonProperty(PropertyName = "review_count")]
        public int ReviewCount { get; set; }
        [JsonProperty(PropertyName = "study_program_count")]
        public int StudyProgramCount { get; set; }
        [JsonProperty(PropertyName = "relevant_industry")]
        public int RelevantIndustryPercentage { get; set; }
        [JsonProperty(PropertyName = "competence")]
        public float Competence { get; set; }
        [JsonProperty(PropertyName = "strictness")]
        public float Strictness { get; set; }
        [JsonProperty(PropertyName = "delivery")]
        public float Delivery { get; set; }
        [JsonProperty(PropertyName = "personality")]
        public float Personality { get; set; }
    }
}
