using LibrarianSystem.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LibrarianSystem.Controllers
{
    [Route("api")]
    [ApiController]
    public class LibraryController : Controller
    {
        private readonly LibraryService service;
        public LibraryController(LibraryService service)
        {
            this.service = service;
        }
        [Authorize]
        public IActionResult Index()
        {
            var entity = HttpContext.User;
            return Ok($"Welcome to Library API, Librarian {entity.Identity.Name}!"); 
        }
        [HttpPost]
        public async Task<ActionResult> Login([FromForm]string username, [FromForm] string password)
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
                return Ok($"Welcome to Library API, Librarian!");
            }
            return Unauthorized();
        }
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        [Authorize]
        [HttpGet("ActiveUser")]
        public IActionResult ActiveUser()
        {
            var entity = HttpContext.User;
            return Json(entity.Identity.Name);
        }
    }
}
