using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OurFirstWebApp.Properties
{
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public string Index()
        {
            return "Hello World!";
        }
    }
}
