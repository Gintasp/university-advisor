using System.Collections.Generic;

namespace Advisor.Model
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StudySubject> StudySubjects { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public Lecturer(string name)
        {
            Name = name;
        }

        public Lecturer()
        {
        }
    }
}
