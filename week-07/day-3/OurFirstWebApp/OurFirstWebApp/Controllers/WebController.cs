using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OurFirstWebApp.Models;
using OurFirstWebApp.Models.ViewModels;

namespace OurFirstWebApp.Controllers
{

    [Route("")]
    public class WebController : Controller
    {
        public static int counter;
        public WebController()
        {
            counter++;
        }
        [HttpGet("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting(name);
            var model = new IndexViewModel(greeting, counter);
            return View(model);
        }
    }
}
