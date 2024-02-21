using Application.Interfaces;
using Application.Queries;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class GetRentalHandler : IRequestHandler<GetRentalQuery, List<Rental>>
    {
        private readonly IRentalRepository _rentalRepository;

        public GetRentalHandler(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }
        public Task<List<Rental>> Handle(GetRentalQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
