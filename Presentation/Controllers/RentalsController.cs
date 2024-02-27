using Application.Commands;
using Application.DataTransferObjects;
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
            _mapper = mapper;
        }

        // GET: api/<MoviesController>
        //[HttpGet]
        //public async Task<List<Rental>> Get()
        //{
        //    return await _mediator.Send(new GetRentalQuery());
        //}

        [HttpGet]
        public async Task<List<RentalReadDto>> Get()
        {
            var rentals = await _mediator.Send(new GetRentalQuery());

            // Mapper les objets Rental vers RentalDTO en utilisant AutoMapper
            var rentalDTO = _mapper.Map<List<RentalReadDto>>(rentals);

            return rentalDTO;
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
        public async Task<Rental> Get(Guid id)
        {
            return await _mediator.Send(new GetRentalByIdQuery(id));
        }

        //[HttpPost]
        //public async Task <Rental> Post(Rental rental)
        //{
        //   return await _mediator.Send(new AddRentalCommand(rental));
        //}

        [HttpPost]
        public async Task<ActionResult<RentalReadDto>> Post(RentalCreateDto rental)
        {  // Map RentalCreateDto to Rental entity
            var rentalEntity = _mapper.Map<Rental>(rental);



            try
            {
                // Send the Rental entity to the AddRentalCommand
                await _mediator.Send(new AddRentalCommand(rentalEntity));

                // Map the Rental entity to RentalReadDto
                var rentalReadDto = _mapper.Map<RentalReadDto>(rentalEntity);

                // Return the mapped RentalReadDto
                return Ok(rentalReadDto);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during command execution
                return StatusCode(500, $"An error occurred while creating the rental: {ex.Message}");

            }



            ////////////////////////////////////

            //        // map user to read dto
            //        var userReadDto=_mapper.Map<RentalReadDto>(createUser);


            //    return await _mediator.Send(new AddRentalCommand(rental));
            //}



        }
    }
}
