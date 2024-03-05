using AutoMapper;
using LivraiZone.Application.Commands.User;
using LivraiZone.Application.Communs;
using LivraiZone.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Handlers.User
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, OperationResult>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        // private readonly SignInManager<AppUser> _signInManager;

        public AddUserHandler(IMapper mapper, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            //_signInManager = signInManager;


        }

        public async Task<OperationResult> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            //var user = new AppUser
            //{
            //    Fullname = request.Fullname,
            //    Email = request.Email,
            //    Address = request.Address,
            //    UserName = request.Fullname
            //};

            var UserToCreate = _mapper.Map<AppUser>(request);
            UserToCreate.UserName = request.Email;
            UserToCreate.Email = request.Email;


            var result = await _userManager.CreateAsync(UserToCreate, request.PasswordHash);

            if (result.Succeeded)
            {
                return new OperationResult { Status = true, Message = "User registered successfully" };
            }
            else
            {
                // Construction du message d'erreur
                var errorMessage = string.Join(", ", result.Errors.Select(error => error.Description));
                return new OperationResult { Status = false, Message = errorMessage };
            }
        }
    }
}
