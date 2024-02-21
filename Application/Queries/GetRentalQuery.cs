using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{

    // IRequest est l'interface de MdiatR
    public record GetRentalQuery() : IRequest<List<Rental>>;
}
