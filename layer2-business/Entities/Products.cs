﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer2_business.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public  string Name { get; set; }
        public  decimal Price {  get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
