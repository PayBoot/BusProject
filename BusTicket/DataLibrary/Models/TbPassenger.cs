using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbPassenger
    {
        public int Id { get; set; }

        [Required]
        public TbReservation Reservation { get; set; }

        [Required]
        public string TicketNumber { get; set; }

        [Required]
        public TbSeat Seat { get; set; }


    }
}
