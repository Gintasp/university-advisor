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
        public Review(int competence, int strictness, int delivery, int interesting, int personality, int rating, string review)
        {
            Competence = competence;
            Strictness = strictness;
            Delivery = delivery;
            Interesting = interesting;
            Personality = personality;
            OveralRating = rating;
            Text = review;
        }
        public Review(int difficulty, int satisfaction, int usefulness, int interesting, int rating, int theoryPercentage, int practicePercentage, string review)
        {
            Difficulty = difficulty;
            Satisfaction = satisfaction;
            Usefulness = usefulness;
            Interesting = interesting;
            OveralRating = rating;
            TheoryPercentage = theoryPercentage;
            PracticePercentage = practicePercentage;
            Text = review;
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
