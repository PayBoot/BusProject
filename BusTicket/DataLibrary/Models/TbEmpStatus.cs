using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbEmpStatus
    {
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
