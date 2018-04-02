namespace BusTicket.Models
{
    public class UserIndexListingModel
    {
        public int Id { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string FirstName { get; set; }
       

        public string LastName { get; set; }

        public string Fullname {
            get { return FirstName + " " + LastName; }
        }
        
        public string Email { get; set; }
        
        public string UserType { get; set; }
        
        public string AuthoriseLevel { get; set; }
       
        public string Status { get; set; }
    }
}
