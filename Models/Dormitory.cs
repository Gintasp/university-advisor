using Newtonsoft.Json;
using System.Collections.Generic;

namespace Advisor.Models
{
    [JsonObject(IsReference = true)]
    public class Dormitory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

        public Dormitory()
        {
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
