using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using EasyShop.Models;

namespace EasyShop.Services
{
    public class Basket
    {
        private readonly List<IItem> _items;

        public Basket(List<IItem> items)
        {
            _items = items;
        }

        public decimal CalculateTotalCost(List<string> basketItems)
        {
            Dictionary<string, int> itemCounts = new Dictionary<string, int>();
            foreach (var item in basketItems)
            {
                if (itemCounts.ContainsKey(item))
                    itemCounts[item]++;
                else
                    itemCounts[item] = 1;
            }

            decimal totalCost = 0;
            foreach (var item in _items)
            {
                if (itemCounts.ContainsKey(item.Name))
                    totalCost += item.GetPrice(itemCounts[item.Name]);
            }

            return totalCost;
        }
    }
}
