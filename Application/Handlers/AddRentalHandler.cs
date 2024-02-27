using Application.Commands;
using Application.DataTransferObjects;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    public class AddRentalHandler : IRequestHandler<AddRentalCommand, Guid>
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IMapper _mapper;

        public AddRentalHandler(IRentalRepository rentalRepository,IMapper mapper)
        {
            _mapper=mapper;
            _rentalRepository = rentalRepository;
        }
        public async Task<Guid> Handle(AddRentalCommand request, CancellationToken cancellationToken)
        {
            var RentalToCreate = _mapper.Map<Rental>(request);
            //return Task.FromResult(_rentalRepository.CreateAsync(RentalToCreate);

            await _rentalRepository.CreateAsync(RentalToCreate);

            return RentalToCreate.RentalId;
        }
    }
}
