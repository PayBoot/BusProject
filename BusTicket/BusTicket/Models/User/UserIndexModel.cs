using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusTicket.Models
{
    public class UserIndexModel
    {
        public IEnumerable<UserIndexListingModel> UserListing { get; set; }
    }
}
