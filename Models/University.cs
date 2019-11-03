using Newtonsoft.Json;
using System.Collections.Generic;

namespace Advisor.Models
{
    [JsonObject(IsReference = true)]
    public class University
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<Dormitory> Dormitories { get; set; }

        public University()
        {
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
