using AutoMapper;
using LivraiZone.Application.Commands.User;
using LivraiZone.Application.Communs;
using LivraiZone.Application.DTO;
using LivraiZone.Application.Queries.User;
// LivraiZone.Application.UserFeature.Queries;
using LivraiZone.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LivraiZone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IMediator mediator, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mediator = mediator;
            _mapper = mapper;
        }


        //[HttpPost("add-user")]
        //public async Task<IActionResult> Register(UserCreateDto model)
        //{
        //    var response = await _mediator.Send(model);

        //    var user = new AppUser()
        //    {
        //        Fullname = model.Fullname,
        //        Email = model.Email,
        //        //Contact = model.Contact,
        //        Address = model.Address,
        //        UserName = model.Fullname,
        //        PasswordHash = model.Password,
        //    };
        //    var result = await _userManager.CreateAsync(user, user.PasswordHash!);
        //    if (result.Succeeded)
        //        return Ok("Registration made successfully");

        //    return BadRequest("Error occured");
        //}

        [HttpGet("Get-All-user")]
        public async Task<List<UserReadDto>> Get()
        {
            var user = await _mediator.Send(new GetUserQuery());

            // Mapper les objets Rental vers RentalDTO en utilisant AutoMapper

            return user;
        }




        //[HttpPost("login")]
        //public async Task<IActionResult> Login(string email, string password)
        //{
        //    var signInResult = await _signInManager.PasswordSignInAsync(
        //          userName: email!,
        //          password: password!,
        //          isPersistent: false,
        //          lockoutOnFailure: false
        //          );
        //    if (signInResult.Succeeded)
        //    {
        //        return Ok("You are successfully logged in");
        //    }
        //    return BadRequest("Error occured");
        //}

        [HttpPost("add-user")]
        public async Task<OperationResult> Register(AddUserCommand model)
        {


            var response = await _mediator.Send(model);

            return response;
        }

        [HttpPost("login")]
        public async Task<OperationResult> Login(LoginUserCommand model)
        {
            var response = await _mediator.Send(model);

            // return CreatedAtAction(nameof(Get), new { id = response });
            return response;
            
        }

        [HttpPost("ForgotPassword")]
        public async Task<OperationResult> ForgotPassword(ForgotPasswordCommand model)
        {
            var response = await _mediator.Send(model);

            // return CreatedAtAction(nameof(Get), new { id = response });
            return response;

        }

        [HttpPost("ResetPassword")]
        public async Task<OperationResult> ResetPassword(ResetPasswordCommand model)
        {
            var response = await _mediator.Send(model);

            // return CreatedAtAction(nameof(Get), new { id = response });
            return response;

        }
    }
}
