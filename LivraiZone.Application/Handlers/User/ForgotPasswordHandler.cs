using AutoMapper;
using LivraiZone.Application.Commands.User;
using LivraiZone.Application.Communs;
using LivraiZone.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Handlers.User
{
    public class ForgotPasswordHandler : IRequestHandler<ForgotPasswordCommand, OperationResult>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;


        public ForgotPasswordHandler(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
    }

        public async Task<OperationResult> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            var UserForget = _mapper.Map<AppUser>(request);
            UserForget.Email = request.Email;

            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                // L'utilisateur avec cet email n'existe pas
                return new OperationResult { Status = false, Message = "No user found with this email" };
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            // Vous pouvez maintenant envoyer ce jeton par e-mail à l'utilisateur
            

            return new OperationResult { Status = true, Message = "Password reset token generated successfully,le token est  " , Token = token };
        }
    }
}
