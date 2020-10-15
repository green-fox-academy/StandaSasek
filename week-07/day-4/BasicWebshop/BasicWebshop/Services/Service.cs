using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebshop.Models;

namespace BasicWebshop.Services
{
    public class Service
    {
        public static List<ShopItem> ListItems()
        {
            var items = new List<ShopItem>()
            {
                {new ShopItem("Running shoes", "Nike running shoes for every day sport", 1000, 5)},
                {new ShopItem("Printer", "Some HP printer that will print", 3000, 2)},
                {new ShopItem("Coca cola", "0.5l standard coke", 25, 0)},
                {new ShopItem("Wokin", "Chicken with fried rice and WOKIN sauce", 119, 100)},
                {new ShopItem("T-shirt", "Blue with a corgi on a bike", 300, 1)}
            };
            return items;
        }
        public static List<ShopItem> OnlyAvailable()
        {
            var onlyAvailable = ListItems().Where(o => o.QuantityOfStock > 0).ToList();
            return onlyAvailable;
        }
        public static List<ShopItem> OrderByCheapest()
        {
            var orderByCheapest = ListItems().OrderBy(o => o.Price).ToList();
            return orderByCheapest;
        }
        public static List<ShopItem> ContainsNike()
        {
            var onlyContainsNike = ListItems().Where(o => o.Name.ToLower().Contains("nike") || o.Description.ToLower().Contains("nike")).ToList();
            return onlyContainsNike;
        }
        public static double AverageStock()
        {
            double averageStock = ListItems().Average(a => a.QuantityOfStock);
            return averageStock;
        }
        public static string MostExpensive()
        {
            var mostExpensive = ListItems().OrderByDescending(o => o.Price).ToList();
            return mostExpensive[0].Name;
        }
    }
}
