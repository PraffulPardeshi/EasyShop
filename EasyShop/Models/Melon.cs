using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyShop.Models
{
    public class Melon : IItem
    {
        public string Name => "Melon";
        public decimal GetPrice(int quantity) => (quantity / 2 + quantity % 2) * 0.50m;
    }
}
