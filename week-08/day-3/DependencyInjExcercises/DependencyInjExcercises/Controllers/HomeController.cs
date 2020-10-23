using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjExcercises.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjExcercises
{
    [Route("useful")]
    public class HomeController : Controller
    {
        private readonly UtilityService service;
        public HomeController(UtilityService service)
        {
            this.service = service;
        }
        [HttpGet("")]
        public IActionResult Useful()
        {
            return View("useful");
        }
        [HttpGet("colored")]
        public IActionResult UsefulColored()
        {
            var usefulColored = service.RandomColor();
            ViewBag.Background = usefulColored;
            return View("useful");
        }
        [HttpGet("email")]
        public IActionResult ValidateEmail(string email)
        {
            var emailChecked = service.ValidateEmail(email);
            ViewBag.CheckedEmail = emailChecked;
            return View("email");
        }
        [HttpGet("encoder")]
        public IActionResult Encoder(string word, int number)
        {
            var result = service.Caesar(word, number);
            ViewBag.Caesar = result;
            return View("encoder");
        }
        [HttpGet("decoder")]
        public IActionResult Decoder(string word, int number)
        {
            var result = service.Caesar(word, -number);
            ViewBag.Caesar = result;
            return View("decoder");
        }
    }
}
