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
    [Route("")]
    public class HomeController : Controller
    {
        private readonly HomeService service;
        public HomeController(HomeService service)
        {
            this.service = service;
        }
        [Authorize]
        [HttpGet("Index")]
        public IActionResult Index()
        {
            var entity = HttpContext.User;
            return Ok($"Welcome to Library, our dear {entity.Identity.Name}!");
        }
        [Authorize]
        [HttpGet("Librarian")]
        public IActionResult Librarian()
        {
            var entity = HttpContext.User;
            return Ok($"Welcome to Library, Librarian {entity.Identity.Name}!");
        }
        [HttpGet("Login")]
        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost("Login")]
        public async Task<ActionResult> Login(string login, string password)
        {
            var entityUser = service.Login(login, password);

            if (String.IsNullOrEmpty(entityUser.Login))
            {
                return RedirectToAction("Login");
            }
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, entityUser.Login) };
            var identity = new ClaimsIdentity(claims, "CookieAuth");
            var principle = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(principle);

            var returnUrl = TempData["returnUrl"] as string;

            if (entityUser.Librarian)
            {
                return RedirectToAction("Librarian");
            }
            return LocalRedirect(returnUrl ?? "/");
        }
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
