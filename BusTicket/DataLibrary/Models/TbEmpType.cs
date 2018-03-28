using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbEmpType
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
