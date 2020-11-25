using LibrarianSystem.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly HomeService service;
        public HomeController(HomeService service)
        {
            this.service = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return Ok("Welcome to Library");
        }
        [HttpPost]
        public async Task<ActionResult> Login(string login, string password)
        {
            var entityUser = service.Login(login, password);

            if (entityUser is null)
            {
                return RedirectToAction("Login");
            }

            var returnUrl = TempData["returnUrl"] as string;

            return LocalRedirect(returnUrl ?? "/");
        }
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
