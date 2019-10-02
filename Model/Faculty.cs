using System.Collections.Generic;

namespace Advisor.Model
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<StudyProgram> StudyPrograms { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }

        public Faculty()
        {
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
