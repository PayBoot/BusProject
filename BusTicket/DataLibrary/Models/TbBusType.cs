using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbBusType
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
