using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbTripAttendant
    {
        public int Id { get; set; }

        [Required]
        public TbEmployee Staff { get; set; }

        [Required]
        public TbTrip Trip { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public string DateOfRecord { get; set; }
    }
}
