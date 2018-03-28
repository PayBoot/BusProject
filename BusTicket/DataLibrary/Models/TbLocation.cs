using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbLocation
    {
        public int Id { get; set; }

        [Required]
        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public virtual IEnumerable<TbBus> Bus { get; set; }
        
    }
}
