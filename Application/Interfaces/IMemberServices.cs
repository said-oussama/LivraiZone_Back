﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    //This interface is use for Bussiness Rule / USE CASE
    public interface IMemberService
    {
        List<Member> GetAllMembers();
    }
}
