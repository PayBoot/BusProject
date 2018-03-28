using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbBusStatus
    {
        public int Id { get; set; }

        [Required]
        public string status { get; set; }
        public string Description { get; set; }
    }
}
