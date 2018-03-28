using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbEmployee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TbEmpType EmpType { get; set; }
                
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [Required]
        public TbEmpStatus Status { get; set; }
        
        public string CurVillege { get; set; }
        public string CurDistrict { get; set; }
        public string CurProvince { get; set; }
    }
}
