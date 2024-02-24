﻿using Application.DataTransferObjects;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class RentalAM : Profile
    {
        public RentalAM()
        {
            // source -> destination

            CreateMap<Rental,RentalReadDto>();  
        }
    }
}
