namespace Advisor.Model
{
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
        public int UserId { get; set; }
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
        public Review(int salary, int difficulty, int satisfaction, bool relevantIndustry, int careerStartYear, int rating, string text)
        {
            Salary = salary;
            Difficulty = difficulty;
            Satisfaction = satisfaction;
            RelevantIndustry = relevantIndustry;
            CareerStartYear = careerStartYear;
            OveralRating = rating;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
        public string AllToString()
        {
            return $"{Text},{OveralRating},{Salary},{Difficulty},{Satisfaction},{RelevantIndustry},{Usefulness},{Interesting}," +
                $"{TheoryPercentage},{PracticePercentage},{Competence},{Strictness},{Delivery},{Personality},{CareerStartYear}";
        }
    }
}
