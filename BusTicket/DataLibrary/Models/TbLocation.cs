using System.Collections.Generic;

namespace DataLibrary.Models
{
    public class TbLocation
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public virtual IEnumerable<TbBus> Bus { get; set; }
        
    }
}
