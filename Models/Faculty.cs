using Newtonsoft.Json;
using System.Collections.Generic;

namespace Advisor.Models
{
    [JsonObject(IsReference = true)]
    public class Faculty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<StudyProgram> StudyPrograms { get; set; }
        [JsonIgnore]
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
