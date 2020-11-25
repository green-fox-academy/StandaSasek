using LibrarianSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult Index()
        {
            return Ok("Welcome to Library API");
        }
    }
}
