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
            return ListItems().Where(o => o.QuantityOfStock > 0).ToList();
        }
        public static List<ShopItem> OrderByCheapest()
        {
            return ListItems().OrderBy(o => o.Price).ToList();
        }
        public static List<ShopItem> ContainsNike()
        {
            return ListItems().Where(o => o.Name.ToLower().Contains("nike") || o.Description.ToLower().Contains("nike")).ToList();
        }
        public static double AverageStock()
        {
            return ListItems().Average(a => a.QuantityOfStock);
        }
        public static string MostExpensive()
        {
            return ListItems().OrderByDescending(o => o.Price).ToList()[0].Name;
        }
        public static List<ShopItem> Search(string searchTask)
        {
            return ListItems().Where(o => o.Name.ToLower().Contains(searchTask) || o.Description.ToLower().Contains(searchTask)).ToList();
        }
    }
}
