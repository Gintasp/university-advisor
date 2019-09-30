using System.Collections.Generic;

namespace Advisor.Model
{
    public class University
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }

        public University()
        {
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
