namespace Advisor.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual StudySubject StudySubject { get; set; }
        public virtual StudyProgram StudyProgram { get; set; }
        public virtual Lecturer Lecturer { get; set; }

        public Review()
        {
        }
    }
}
