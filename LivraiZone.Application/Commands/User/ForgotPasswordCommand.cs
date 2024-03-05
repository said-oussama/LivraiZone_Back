using LivraiZone.Application.Communs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Commands.User
{
    public record ForgotPasswordCommand : IRequest<OperationResult>
    {
        public string Email { get; set; }
    }

}
