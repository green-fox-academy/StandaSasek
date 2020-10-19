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
            return View(new IndexViewModels(shopItems));
        }
        [HttpGet("only-available")]
        public IActionResult OnlyAvailable()
        {
            var onlyAvailable = Service.OnlyAvailable();
            return View("Index", new IndexViewModels(onlyAvailable));
        }
        [HttpGet("cheapest-first")]
        public IActionResult CheapestFirst()
        {
            var cheapestFirst = Service.OrderByCheapest();
            return View("Index", new IndexViewModels(cheapestFirst));
        }
        [HttpGet("contains-nike")]
        public IActionResult ContainsNike()
        {
            var containsNike = Service.ContainsNike();
            return View("Index", new IndexViewModels(containsNike));
        }
        [HttpGet("average-stock")]
        public IActionResult AverageStock()
        {
            var averageStock = Service.AverageStock();
            return View("Index", new IndexViewModels(Service.ListItems(), averageStock));
        }
        [HttpGet("most-expensive")]
        public IActionResult MostExpensive()
        {
            var mostExpensive = Service.MostExpensive();
            return View("Index", new IndexViewModels(Service.ListItems(), 0, mostExpensive));
        }
    }
}
