using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRentalService
    {
        List<Rental> GetAllRentals();
        Rental CreateRental(Rental rental);
    }
}
