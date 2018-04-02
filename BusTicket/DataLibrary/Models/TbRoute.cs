using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class TbRoute
    {
        public int Id { get; set; }

        public TbLocation StartLocation { get; set; }

        public TbLocation EndLocation { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfRecord { get; set; }

        public virtual IEnumerable<TbTrip> Trip { get; set; }
    }
}
