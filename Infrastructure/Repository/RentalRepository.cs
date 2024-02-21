//using Application;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RentalRepository : IRentalRepository
    {
        public static List<Rental> rentals = new List<Rental>()
        {
            //new Movie{Id=1,Name="passion of christ",Cost=2},
            //new Movie{Id=2,Name="Home Alone 4",Cost=1}
        };
        private readonly Context _rentalContext;

        public RentalRepository(Context rentalContext)
        {
            _rentalContext = rentalContext;
        }

        public Rental CreateRental(Rental rental)
        {
            _rentalContext.Rentals.Add(rental);
            _rentalContext.SaveChanges();
            return rental;


        }

        public List<Rental> GetAllRentals()
        {
            return _rentalContext.Rentals.ToList();
        }
    }
}
