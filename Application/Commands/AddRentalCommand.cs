using Application.DataTransferObjects;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public record AddRentalCommand : IRequest<Guid>
    {
        //public Guid RentalId { get; set; }

        public decimal TotalCost { get; set; }
        public DateTime RentalDate { get; set; }
    }
}
