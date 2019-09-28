using System.Collections.Generic;

namespace Advisor.Model
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<StudyProgram> StudyPrograms { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; }

        public Faculty()
        {
        }
    }
}
