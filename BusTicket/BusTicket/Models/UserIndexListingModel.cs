using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    public class UserIndexListingModel
    {
        public int Id { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string FirstName { get; set; }
       

        public string LastName { get; set; }

        public string Fullname
        {
            get
            {
                return Fullname + " " + LastName;
            }
            set
            {
                Fullname = value;
            }
        }
        
        public string Email { get; set; }
        
        public string UserType { get; set; }
        
        public string AuthoriseLevel { get; set; }
       
        public string Status { get; set; }
    }
}
