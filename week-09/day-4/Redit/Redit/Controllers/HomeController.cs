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
        private readonly IPostService service;
        public HomeController(IPostService service)
        {
            this.service = service;
        }
        [HttpGet("")]
        public IActionResult Index(int page = 0)
        {
            const int pageSize = 3;
            var list = service.ListAllPosts();
            var count = list.Count();
            var data = list.Skip(page * pageSize).Take(pageSize).ToList();
            this.ViewBag.MaxPage = (count / pageSize) - (count % pageSize == 0 ? 1 : 0);
            this.ViewBag.Page = page;
            return View("index", new IndexViewModel(data));
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
        [HttpGet("vote")]
        public IActionResult Vote(int id, int value)
        {
            service.Vote(id, value);
            return RedirectToAction("index");
        }
        [HttpGet("update")]
        public IActionResult Update(int id)
        {
            var post = service.ReadPost(id);
            return View("update", new IndexViewModel(post));
        }
        [HttpPost("update")]
        public IActionResult Updated(Post post)
        {
            var user = new User();
            post.Author = user;
            post.UserId = user.Id;
            service.UpdatePost(post);
            return RedirectToAction("index");
        }
    }
}
