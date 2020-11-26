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
        /*[Authorize]*/
        public IActionResult Index()
        {
            var entity = HttpContext.User;
            return Ok($"Welcome to Library API, Librarian {entity.Identity.Name}!");
        }
        [HttpPost]
        public async Task<ActionResult> Login([FromForm] string username, [FromForm] string password)
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
        /*[Authorize]*/
        [HttpGet("active-user")]
        public IActionResult ActiveUser()
        {
            var entity = HttpContext.User;
            return Json(entity.Identity.Name);
        }
        [HttpPost("register-user")]
        public ActionResult RegisterUser([FromForm] string name, [FromForm] string username, [FromForm] string password)
        {
            var userRegistration = service.RegisterUser(name, username, password);

            if (!userRegistration)
            {
                return BadRequest("This login name is already used. Please choose different.");
            }

            return Ok("User registration was successfull.");
        }
        [HttpPost("add-book")]
        public ActionResult AddBook([FromForm] string name, [FromForm] string author)
        {
            // HACK remove with functioning Auth
            // get default Librarian
            var librarian = service.GetDefaultLibrarian();

            var bookAdding = service.AddBook(name, author, librarian); // TODO add some checking if needed

            return Ok("Book was added.");
        }
        [HttpGet("get-clients")]
        public ActionResult GetClients()
        {
            var clients = service.GetClients();

            return Ok(new { clients });
        }
        [HttpGet("get-librarians")]
        public ActionResult GetLibrarians()
        {
            var clients = service.GetLibrarians();

            return Ok(new { clients });
        }
        [HttpGet("get-books")]
        public ActionResult GetBooks()
        {
            var books = service.GetBooks();

            return Ok(new { books });
        }
        [HttpGet("get-available-books")]
        public ActionResult GetAvailableBooks()
        {
            var availableBooks = service.GetAvailableBooks();

            return Ok(new { availableBooks });
        }
        [HttpPost("borrow-book")]
        public ActionResult BorrowBook([FromForm] string bookName, [FromForm] string clientName) // HACK remove client with functioning Auth
        {
            // HACK remove with functioning Auth
            var actualClient = service.GetClientByName(clientName);
            var actualBook = service.GetBookByName(bookName);

            var borrow = service.AddBorrow(actualBook, actualClient); // TODO add some checking 

            return Ok("Book was borrowed.");
        }
        [HttpPost("return-book")]
        public ActionResult ReturnBook([FromForm] string bookName, [FromForm] string clientName) // HACK remove client with functioning Auth
        {
            // HACK remove with functioning Auth
            var actualClient = service.GetClientByName(clientName);
            var actualBook = service.GetBookByName(bookName);

            var borrow = service.EndBorrow(actualBook, actualClient); // TODO add some checking 

            return Ok("Book was returned.");
        }
    }
}
