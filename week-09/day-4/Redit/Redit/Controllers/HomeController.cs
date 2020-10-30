using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Redit.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("submit")]
        public IActionResult Submit()
        {
            return View();
        }
        [HttpPost("submit")]
        public IActionResult Submited()
        {

            return RedirectToAction("index");
        }
    }
}
