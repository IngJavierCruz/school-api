﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class ResponseApi
    {
        public dynamic data { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }
}
