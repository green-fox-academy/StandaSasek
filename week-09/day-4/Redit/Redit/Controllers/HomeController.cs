using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Redit.Models.Entities;
using Redit.Models.ViewModels;
using Redit.Services;

namespace Redit.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly IPostServices service;
        public HomeController(IPostServices service)
        {
            this.service = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var list = service.ListAllPosts();
            return View("index", new IndexViewModel(list));
        }
        [HttpGet("submit")]
        public IActionResult Submit()
        {
            return View();
        }
        [HttpPost("submit")]
        public IActionResult Submited(Post post)
        {
            var user = new User();
            post.Author = user;
            post.UserId = user.Id;
            service.Submit(post);
            return RedirectToAction("index");
        }
    }
}
