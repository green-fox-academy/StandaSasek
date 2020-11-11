using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatA.Models.Entities;
using ChatA.Models.ViewModels;
using ChatA.Services;

namespace ChatA.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly UserService userService;
        private readonly MessageService messageService;
        public HomeController(UserService userService)
        {
            this.userService = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            var userData = service.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(userData.ApiKey);

            return View("index", new IndexViewModel(userData));
        }
        [HttpGet("register")]
        public IActionResult RegisterUser()
        {
            var userData = service.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(userData.ApiKey);
            return View("register");
        }
        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] string login, [FromBody] string password)
        {
            var message = service.RegisterUser(login, password);
            TempData["Message"] = message;
            return RedirectToAction("index");
        }
        [HttpGet("login")]
        public IActionResult LoginUser()
        {
            var user = new LoggedUser();
            var message = service.LoginUser(user);
            TempData["Message"] = message;
            return RedirectToAction("index");
        }
        [HttpGet("user")]
        public IActionResult UserData()
        {
            var newUserData = service.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(newUserData.ApiKey);
            return View("user", new IndexViewModel(newUserData));
        }
        [HttpGet("update")]
        public IActionResult UpdateUser()
        {
            var userData = service.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(userData.ApiKey);
            return View("update", new IndexViewModel(userData));
        }
        [HttpPost("update")] // TODO do not work, but why?
        public IActionResult UpdatedUser([FromForm] string userName, [FromForm] string avatarUrl)
        {
            service.UpdateUser(userName, avatarUrl);
            var newUserData = service.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(newUserData.ApiKey);
            return View("user", new IndexViewModel(newUserData));
        }
        [HttpGet("logout")]
        public IActionResult LogoutUser()
        {
            var message = service.LogoutUser();
            TempData["Message"] = message;
            return RedirectToAction("index");
        }
        [HttpGet("message")]
        public IActionResult PostMessage()
        {
            var userData = service.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(userData.ApiKey);
            return View("update", new IndexViewModel(userData));
        }
        [HttpPost("update")] // TODO do not work, but why?
        public IActionResult UpdatedUser([FromForm] string userName, [FromForm] string avatarUrl)
        {
            service.UpdateUser(userName, avatarUrl);
            var newUserData = service.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(newUserData.ApiKey);
            return View("user", new IndexViewModel(newUserData));
        }
    }
}
