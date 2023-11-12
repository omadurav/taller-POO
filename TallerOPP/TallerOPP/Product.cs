﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerOPP
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $" {Id} Description: {Description}";
                
        }
    }
}
