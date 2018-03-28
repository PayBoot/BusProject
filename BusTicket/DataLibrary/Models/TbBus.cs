using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbBus
    {
        public int Id { get; set; }

        [Required]
        public TbBusType Type { get; set; }

        public string Name { get; set; }

        [Required]
        public string PlateNumber { get; set; }

        public TbLocation Location { get; set; }

        [Required]
        public double SeatCapacity { get; set; }

        [Required]
        public TbBusStatus Status { get; set; }

        public virtual IEnumerable<TbSeat> Seat { get; set; }
    }
}
