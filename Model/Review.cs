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
        public int? StudySubjectId { get; set; }

        public Review()
        {
        }
    }
}
