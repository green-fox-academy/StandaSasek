using LibrarianSystem.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LibrarianSystem.Controllers
{
    [Authorize]
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
            var entity = HttpContext.User;
            return Ok($"Welcome to Library, our dear {entity.Identity.Name}!");
        }
        [HttpGet("Librarian")]
        public IActionResult Librarian()
        {
            var entity = HttpContext.User;
            return Ok($"Welcome to Library, Librarian {entity.Identity.Name}!"); // TODO how to show user Name instead of Login?
        }
        [AllowAnonymous]
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult> Login(string username, string password)
        {
            var entityUser = service.Login(username, password);

            if (entityUser is null || String.IsNullOrEmpty(entityUser.Login))
            {
                return RedirectToAction("Login");
            }
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, entityUser.Name) };
            var identity = new ClaimsIdentity(claims, "CookieAuth");
            var principle = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(principle);

            if (entityUser.Librarian)
            {
                return RedirectToAction("Librarian");
            }
            return RedirectToAction("Index");
        }
        [HttpGet("Logout")]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
