using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicWebshop.Models;
using BasicWebshop.Services;

namespace BasicWebshop.Controllers
{
    [Route("")]
    public class WebShopController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            var shopItems = Service.ListItems();
            ViewBag.Items = shopItems;
            return View();
        }
        [HttpGet("only-available")]
        public IActionResult OnlyAvailable()
        {
            var shopItems = Service.OnlyAvailable();
            ViewBag.Items = shopItems;
            return View();
        }
        [HttpGet("cheapest-first")]
        public IActionResult CheapestFirst()
        {
            var shopItems = Service.OrderByCheapest();
            ViewBag.Items = shopItems;
            return View();
        }
        [HttpGet("contains-nike")]
        public IActionResult ContainsNike()
        {
            var shopItems = Service.ContainsNike();
            ViewBag.Items = shopItems;
            return View();
        }
        [HttpGet("average-stock")]
        public IActionResult AverageStock()
        {
            var averageStock = Service.AverageStock();
            return View(averageStock);
        }
        [HttpGet("most-expensive")]
        public IActionResult MostExpensive()
        {
            var mostExpensive = Service.MostExpensive();
            return View(mostExpensive);
        }
    }
}
