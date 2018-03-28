using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbUserLog
    {
        public int Id { get; set; }
        public TbUser User { get; set; }
        [DataType(DataType.DateTime)]
        public string Login { get; set; }
        [DataType(DataType.DateTime)]
        public string Logout { get; set; }
    }
}
