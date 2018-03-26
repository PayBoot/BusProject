using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbUser
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Username is needed")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is needed")]
        public string Password { get; set; }
        [Required(ErrorMessage = "First name is needed")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is needed")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is needed")]
        public string Email { get; set; }
        [Required(ErrorMessage = "User type is needed")]
        public string UserType { get; set; }
        [Required(ErrorMessage = "Authorise level is needed")]
        public string AuthoriseLevel { get; set; }
        [Required(ErrorMessage = "User status is needed")]
        public string Status { get; set; }


    }
}
