using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbPrice
    {
        public int Id { get; set; }

        [Required]
        public string PriceType { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public TbRoute Route { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public string DateOfRecord { get; set; }

    }
}
