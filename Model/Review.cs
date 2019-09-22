namespace Advisor.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public User UserId { get; set; }
        public virtual User User { get; set; }

        public Review()
        {
        }
    }
}
