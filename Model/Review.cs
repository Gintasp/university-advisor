namespace Advisor.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public Review()
        {
        }
    }
}
