﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvtifeevaShop.Models.Database
{
    public class Client
    {
        public int ClientId { get; set; }  
        public string Name { get; set;}
        public string Phone { get; set;}
        public string Email { get; set;}
    }
}
