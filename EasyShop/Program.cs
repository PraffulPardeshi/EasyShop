using System;
using System.Collections.Generic;
using System.ComponentModel;
using EasyShop.Models;
using EasyShop.Services;

namespace ShoppingBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dependency Injection: Register available items
            List<IItem> availableItems = new List<IItem>
            {
                new Apple(),
                new Banana(),
                new Melon(),
                new Lime()
            };

            // Inject dependencies into the Basket
            Basket basket = new Basket(availableItems);

            // Example basket
            List<string> basketItems = new List<string> { "Apple", "Apple", "Banana", "Melon", "Melon", "Lime", "Lime", "Lime", "Lime" };

            // Calculate total cost
            decimal totalCost = basket.CalculateTotalCost(basketItems);
            Console.WriteLine($"Total cost of the basket: £{totalCost:F2}");
        }
    }
}
