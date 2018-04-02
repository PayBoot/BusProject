namespace BusTicket.Models.User
{
    public class UserDetailModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserType { get; set; }

        public string AuthoriseLevel { get; set; }

        public string Status { get; set; }
    }
}

