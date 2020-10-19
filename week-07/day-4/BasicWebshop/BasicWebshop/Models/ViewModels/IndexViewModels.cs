using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebshop.Models;
using BasicWebshop.Services;

namespace BasicWebshop.Models
{
    public class IndexViewModels
    {
        public List<ShopItem> ShopItems { get; set; }
        public double AverageStock { get; set; }
        public string MostExpensive { get; set; }
        public IndexViewModels(List<ShopItem> shopItems, double averageStock = 0, string mostExpensive = null)
        {
            ShopItems = shopItems;
            AverageStock = averageStock;
            MostExpensive = mostExpensive;
        }
    }
}
