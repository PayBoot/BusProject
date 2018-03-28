using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbSeat
    {
        public int Id { get; set; }

        [Required]
        public int SeatName { get; set; }

        [Required]
        public TbBus Bus { get; set; }
    }
}
