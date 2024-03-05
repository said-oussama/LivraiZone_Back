using LivraiZone.Application.Communs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Commands.User
{
    public record LoginUserCommand : IRequest<OperationResult>
    {
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
    }
}
