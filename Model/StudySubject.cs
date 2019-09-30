using System.Collections.Generic;

namespace Advisor.Model
{
    public class StudySubject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual StudyProgram StudyProgram { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public StudySubject()
        {
        }
    }
}
