﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyShop.Models
{
    public class Apple : IItem
    {
        public string Name => "Apple";
        public decimal GetPrice(int quantity) => quantity * 0.35m;
    }
}
