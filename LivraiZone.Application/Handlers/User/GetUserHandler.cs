using AutoMapper;
using LivraiZone.Application.DTO;
using LivraiZone.Application.Interfaces;
using LivraiZone.Application.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Handlers.User
{


    public class GetUserHandler : IRequestHandler<GetUserQuery, List<UserReadDto>>
    {
        private readonly IUserRepository _rentalRepository;
        private readonly IMapper _mapper;

        public GetUserHandler(IUserRepository rentalRepository, IMapper mapper)
        {
            _rentalRepository = rentalRepository;
            _mapper = mapper;
        }
        public async Task<List<UserReadDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var rentals = await _rentalRepository.GetAsync();
            var data = _mapper.Map<List<UserReadDto>>(rentals);
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
