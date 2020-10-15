using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OurFirstWebApp.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        public static int counter;
        public HomeController()
        {
            counter++;
        }
        [HttpGet("index")]
        public string Index()
        {
            ViewBag.Counter = counter;
            return "Hello from the Controller!";
        }
    }
}
