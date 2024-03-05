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
    public class ResetPasswordHandler : IRequestHandler<ResetPasswordCommand, OperationResult>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public ResetPasswordHandler(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper= mapper;
    }

        public async Task<OperationResult> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {

            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                return new OperationResult { Status = false, Message = "No user found with this email" };
            }

            var result = await _userManager.ResetPasswordAsync(user, request.Token, request.NewPassword);

            if (result.Succeeded)
            {
                return new OperationResult { Status = true, Message = "Password reset successfully" };
            }
            else
            {
                return new OperationResult { Status = false, Message = "Failed to reset password" };
            }
        }
    }
}
