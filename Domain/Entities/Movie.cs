using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public decimal RentalDuration { get; set; }
        //many to many relation

        public IList<MovieRental> MovieRentals { get; set; }
    }
}
