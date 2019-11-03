using Newtonsoft.Json;

namespace Advisor.Models
{
    [JsonObject(IsReference = true)]
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int OveralRating { get; set; }
        public int Salary { get; set; }
        public int Difficulty { get; set; }
        public int Satisfaction { get; set; }
        public bool RelevantIndustry { get; set; }
        public int CareerStartYear { get; set; }
        public int Usefulness { get; set; }
        public int Interesting { get; set; }
        public int TheoryPercentage { get; set; }
        public int PracticePercentage { get; set; }
        public string UserId { get; set; }
        public int Competence { get; set; }
        public int Strictness { get; set; }
        public int Delivery { get; set; }
        public int Personality { get; set; }
        public virtual User User { get; set; }
        public virtual Course Course { get; set; }
        public virtual StudyProgram StudyProgram { get; set; }
        public virtual Lecturer Lecturer { get; set; }

        public Review()
        {
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
