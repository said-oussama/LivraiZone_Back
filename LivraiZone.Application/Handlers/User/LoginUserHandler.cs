using AutoMapper;
using LivraiZone.Application.Commands.User;
using LivraiZone.Application.Communs;
using LivraiZone.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace LivraiZone.Application.Handlers.User
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, OperationResult>
    {
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginUserHandler(IMapper mapper, SignInManager<AppUser> SignInManager)
        {
            _mapper = mapper;
            _signInManager = SignInManager;
            //_signInManager = signInManager;


        }

        public async Task<OperationResult> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var UserToLogin = _mapper.Map<AppUser>(request);
            //UserToLogin.Email = request.Email;


            var result = await _signInManager.PasswordSignInAsync(
                  userName: UserToLogin.Email!,
                  password: UserToLogin.PasswordHash!,
                  isPersistent: false,
                  lockoutOnFailure: false
                  );
            if (result.Succeeded)
            {
                return new OperationResult { Status = true, Message = "You are successfully logged in" };
            }
            else
            {
                return  GetErrorMessage(result);
            }
        }

        private OperationResult GetErrorMessage(SignInResult signInResult)
        {
            if (signInResult.IsLockedOut)
            {
                return new OperationResult { Status = false, Message = "User account is locked out" };
            }
            else if (signInResult.IsNotAllowed)
            {
                return new OperationResult { Status = false, Message = "User is not allowed to sign in" };
            }
            else
            {
                return new OperationResult { Status = false, Message = "Invalid login attempt" }; 
            }
        }
    }
 }

