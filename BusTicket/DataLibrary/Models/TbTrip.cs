using System;
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
        public DateTime DepartureTime { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime ArrivalTime { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfRecord { get; set; }

        public IEnumerable<TbTripAttendant> TripAttendent { get; set; }
    }
}
