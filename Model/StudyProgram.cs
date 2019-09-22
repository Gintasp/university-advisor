using System.Collections.Generic;

namespace Advisor.Model
{
    public class StudyProgram
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public StudyProgram()
        {
        }
    }
}
