using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RentalService 
        //: IRentalService
    {
        private readonly IRentalRepository _rentalRepository;
        // constructor dependency injection
        public RentalService(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }

        //public Rental CreateRental(Rental rental)
        //{
        //    _rentalRepository.CreateRental(rental);
        //    return rental;
        //}

        //public List<Rental> GetAllRentals()
        //{
        //    var rentals = _rentalRepository.GetAllRentals();
        //    return rentals;
        //}
    }
}
