using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OurFirstWebApp.Models;

namespace OurFirstWebApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {
            var greeting = new Greeting("Hello, " + name);
            return greeting;
        }
    }
}
