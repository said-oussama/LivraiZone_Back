﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivraiZone.Application.Communs
{
    public  class OperationResult
    {

        public bool Status { get; set; }
        public string Message { get; set; }

        public string? Token { get; set; }
    }
}
