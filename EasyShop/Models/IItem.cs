using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyShop.Models
{
    public interface IItem
    {
        string Name { get; }
        decimal GetPrice(int quantity);
    }
}