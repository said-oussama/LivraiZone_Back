using Application.Queries;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers
{
    //public class GetRentalByIdHandler : IRequestHandler<GetRentalByIdQuery, Rental>
    //{

    //    private readonly IMediator _mediator;

    //    public GetRentalByIdHandler(IMediator mediator)
    //    {
    //        _mediator = mediator;
    //    }
    //    public async Task<Rental> Handle(GetRentalByIdQuery request, CancellationToken cancellationToken)
    //    {
    //        var rentals = await _mediator.Send(new GetRentalQuery());
    //        var rental = rentals.FirstOrDefault(u => u.RentalId == request.id);
    //        return rental;
    //    }
    //}
}
