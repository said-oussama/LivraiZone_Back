using Application.DataTransferObjects;
using Application.Interfaces;
using Application.Queries;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class GetRentalHandler : IRequestHandler<GetRentalQuery, List<RentalReadDto>>
    {
        private readonly IRentalRepository _rentalRepository;
        private readonly IMapper _mapper;

        public GetRentalHandler(IRentalRepository rentalRepository,IMapper mapper)
        {  
            _rentalRepository = rentalRepository;
            _mapper = mapper;
        }
        public async Task<List<RentalReadDto>> Handle(GetRentalQuery request, CancellationToken cancellationToken)
        {
            var rentals = await _rentalRepository.GetAsync();
            var data = _mapper.Map<List<RentalReadDto>>(rentals);
            return data;
        }

        //Task<List<RentalReadDto>> IRequestHandler<GetRentalQuery, List<RentalReadDto>>.Handle(GetRentalQuery request, CancellationToken cancellationToken)
        //{
        //    var rentals = await _rentalRepository.GetAsync();
        //    var data = _mapper.Map<List<Rental>>(rentals);
        //    return data;
        //}
    }

}
