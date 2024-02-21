using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _service;

        public RentalController(IRentalService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Rental>> Get()
        {
            var RentelsFromService = _service.GetAllRentals();
            return Ok(RentelsFromService);
        }
        [HttpPost]
        public ActionResult<Rental> PostRental(Rental Rentals)
        {

            var rentals = _service.CreateRental(Rentals);
            return Ok(rentals);
        }



    }
}
