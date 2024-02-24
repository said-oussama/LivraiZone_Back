using Application.Commands;
using Application.Interfaces;
using Application.Queries;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public RentalsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper= mapper;
        }

        // GET: api/<MoviesController>
        //[HttpGet]
        //public async Task<List<Rental>> Get()
        //{
        //    return await _mediator.Send(new GetRentalQuery());
        //}

        [HttpGet]
        public async Task<List<RentalDTO>> Get()
        {
            var rentals = await _mediator.Send(new GetRentalQuery());

            // Mapper les objets Rental vers RentalDTO en utilisant AutoMapper
            var rentalDTOs = _mapper.Map<List<RentalDTO>>(rentals);

            return rentalDTOs;
        }


        //private readonly IRentalService _service;

        //public RentalController(IRentalService service)
        //{
        //    _service = service;
        //}
        //[HttpGet]
        //public ActionResult<List<Rental>> Get()
        //{
        //    var RentelsFromService = _service.GetAllRentals();
        //    return Ok(RentelsFromService);
        //}
        //[HttpPost]
        //public ActionResult<Rental> PostRental(Rental Rentals)
        //{

        //    var rentals = _service.CreateRental(Rentals);
        //    return Ok(rentals);
        //}

        [HttpGet("{id}")]
        public async Task<Rental> Get(int id)
        {
            return await _mediator.Send(new GetRentalByIdQuery(id));
        }

        [HttpPost]
        public async Task <Rental> Post(Rental rental)
        {
           return await _mediator.Send(new AddRentalCommand(rental));
        }



    }
}
