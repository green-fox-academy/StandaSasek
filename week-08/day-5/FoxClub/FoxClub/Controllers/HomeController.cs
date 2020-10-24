using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;
using FoxClub.Services;

namespace FoxClub
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            return View();
        }
        [HttpGet("login")]
        public IActionResult Login(string name)
        {
            return View("login");
        }
    }
}
