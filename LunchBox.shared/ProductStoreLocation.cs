﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
{
    public class ProductStoreLocation
    {
        public Store Store { get; set; }

        public int StoreId { get; set; }

        public Location Location { get; set; }

        public int LocationId { get; set; }

        public Product Product { get; set; }

        public int ProductId { get; set; }

        public decimal Price { get; set; }
    }
}