﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Rental
    {
         //[Key]
        public Guid RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        // one to many relationship
        public ICollection<Member>? Members { get; set; }

        //many to many relation
        public IList<MovieRental>? MovieRentals { get; set; }
    }
}