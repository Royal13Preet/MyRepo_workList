﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Dto_s
{
    public class CreateProduct
    {

        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<int> CategoryIds { get; set; }


    }
}
