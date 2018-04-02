using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbReservation
    {
        public int Id { get; set; }

 
        public TbUser User { get; set; }


        public TbTrip Trip { get; set; }

        [Required]
        public string Status { get; set; }

 
        public TbPrice price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CancelationTime { get; set; }

        [Required]
        public double AmountSeat { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime ReservationTime { get; set; }

        public IEnumerable<TbPassenger> Passengers { get; set; }


    }
}
