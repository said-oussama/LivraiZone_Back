using LivraiZone.Application.Communs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Commands.User
{
    public record AddUserCommand : IRequest<OperationResult>
    {
        public string? Username { get; set; }
        //public int Contact { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
