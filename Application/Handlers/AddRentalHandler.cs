using Application.Commands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class AddRentalHandler : IRequestHandler<AddRentalCommand, Rental>
    {
        private readonly IRentalRepository _rentalRepository;

        public AddRentalHandler(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }
        public Task<Rental> Handle(AddRentalCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_rentalRepository.CreateRental(request.model));
        }
    }
}
