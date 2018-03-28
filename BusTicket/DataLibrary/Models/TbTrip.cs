using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbTrip
    {
        public int Id { get; set; }

        [Required]
        public TbRoute Route { get; set; }

        [Required]
        public TbBus Bus { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public string DepartureTime { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public string ArrivalTime { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public string DateOfRecord { get; set; }

        public virtual IEnumerable<TbTripAttendant> TripAttendent { get; set; }
    }
}
