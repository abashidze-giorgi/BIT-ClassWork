﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_ClassWork.Models
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public Basket basket { get; set; }
    }

}
