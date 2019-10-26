using System.Collections.Generic;

namespace Advisor.Model
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public Lecturer(string name, Faculty faculty)
        {
            Name = name;
            Faculty = faculty;
        }

        public Lecturer()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
