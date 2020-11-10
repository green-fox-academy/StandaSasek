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
            var userData = service.GetUserData();
            if (String.IsNullOrEmpty(userData.ApiKey))
            {
                ViewBag.LoggedUser = false;
            }
            else
            {
                ViewBag.LoggedUser = true;
            }
            return View("index", new IndexViewModel(userData));
        }
        [HttpGet("register")]
        public IActionResult RegisterUser()
        {
            var userData = service.GetUserData();
            if (String.IsNullOrEmpty(userData.ApiKey))
            {
                ViewBag.LoggedUser = false;
            }
            else
            {
                ViewBag.LoggedUser = true;
            }
            return View("register");
        }
        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] string login, [FromBody] string password)
        {
            var message = service.RegisterUser(login, password);
            ViewBag.Message = message;
            return View("index");
        }
        [HttpGet("login")]
        public IActionResult LoginUser()
        {
            var user = new User();
            var message = service.LoginUser(user);
            ViewBag.Message = message;
            var userData = service.GetUserData();
            if (String.IsNullOrEmpty(userData.ApiKey))
            {
                ViewBag.LoggedUser = false;
            }
            else
            {
                ViewBag.LoggedUser = true;
            }
            return View("index", new IndexViewModel(userData));
        }
        [HttpGet("user")]
        public IActionResult UserData()
        {
            var userData = service.GetUserData();
            if (String.IsNullOrEmpty(userData.ApiKey))
            {
                ViewBag.LoggedUser = false;
            }
            else
            {
                ViewBag.LoggedUser = true;
            }
            return View("user", new IndexViewModel(userData));
        }
        [HttpGet("update")]
        public IActionResult UpdateUser()
        {
            var userData = service.GetUserData();
            if (String.IsNullOrEmpty(userData.ApiKey))
            {
                ViewBag.LoggedUser = false;
            }
            else
            {
                ViewBag.LoggedUser = true;
            }
            return View("update", new IndexViewModel(userData));
        }
        [HttpPost("update")] // TODO do not work, but why?
        public IActionResult UpdatedUser([FromBody] string userName, [FromBody] string avatarUrl)
        {
            var userData = service.UpdateUser(userName, avatarUrl);
            var newUserData = service.GetUserData();
            if (String.IsNullOrEmpty(newUserData.ApiKey))
            {
                ViewBag.LoggedUser = false;
            }
            else
            {
                ViewBag.LoggedUser = true;
            }
            return View("user", new IndexViewModel(newUserData));
        }
    }
}
