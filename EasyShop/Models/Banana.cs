using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyShop.Models
{
    public class Banana : IItem
    {
        public string Name => "Banana";
        public decimal GetPrice(int quantity) => quantity * 0.20m;
    }
}
