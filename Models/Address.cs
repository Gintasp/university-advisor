
namespace Advisor.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Nr { get; set; }
        public virtual Dormitory Dormitory { get; set; }
        public virtual Faculty Faculty { get; set; }

        public Address()
        {
        }

        public override string ToString()
        {
            return Street + " " + Nr  + ", " + City;
        }
    }
}
