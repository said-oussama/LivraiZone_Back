using Application.Commands;
using Application.Interfaces;
using Application.Queries;
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

        public RentalsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public async Task<List<Rental>> Get()
        {
            return await _mediator.Send(new GetRentalQuery());
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
