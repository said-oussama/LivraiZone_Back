using LivraiZone.Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Queries.User
{
    public record GetUserQuery : IRequest<List<UserReadDto>>
    {

    }
}
