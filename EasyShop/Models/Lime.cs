using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyShop.Models
{
    public class Lime : IItem
    {
        public string Name => "Lime";
        public decimal GetPrice(int quantity) => ((quantity / 3) * 2 + quantity % 3) * 0.15m;
    }
}
