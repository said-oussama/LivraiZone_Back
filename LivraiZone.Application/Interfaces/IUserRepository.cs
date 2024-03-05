﻿using LivraiZone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Interfaces
{
    public interface IUserRepository : IGenericRepository<AppUser>
    {
    }
}
