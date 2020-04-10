﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Models
{
    public class Sizes
    {
        public int id { get; set; }
        public string size { get; set; }
        public double priceMultiplier { get; set; }
        public bool isAvailable { get; set; }
    }
}