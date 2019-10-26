using System.Collections.Generic;

namespace Advisor.Model
{
    public class StudyProgram
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public StudyProgram()
        {
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
