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
    public class UserController : Controller
    {
        private readonly UserServices service;
        public UserController(UserServices service)
        {
            this.service = service;
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
            var user = new User();
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
            var userData = service.UpdateUser(userName, avatarUrl);
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
    }
}
