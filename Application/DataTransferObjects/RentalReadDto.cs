﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObjects
{
    public class RentalReadDto
    {
        public Guid RentalId { get; set; }
        public decimal TotalCost { get; set; }

        //////////////

       /// public int wess { get; set; }
    }
}
