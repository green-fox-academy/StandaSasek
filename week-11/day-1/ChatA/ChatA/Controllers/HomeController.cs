using System;
using System.Collections.Generic;
using System.Linq;
using ChatA.Models.Entities;
using ChatA.Models.ViewModels;
using ChatA.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatA.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly UserService uService;
        private readonly MessageService mService;

        public HomeController(UserService userService, MessageService messageService)
        {
            this.uService = userService;
            this.mService = messageService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            var userData = uService.GetUserData();
            if (!String.IsNullOrEmpty(userData.ApiKey))
            {
                ViewBag.LoggedUser = true;
                List<Message> messages = mService.GetMessagesByChannel(10); // HACK change number of messages by pagination
                ViewBag.Messages = true;
                return View("index", new IndexViewModel(userData, messages));
            }
            else
            {
                ViewBag.LoggedUser = false;
                ViewBag.Messages = false;
                return View("index", new IndexViewModel(userData));
            }
        }

        [HttpGet("register")]
        public IActionResult RegisterUser()
        {
            var userData = uService.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(userData.ApiKey);
            return View("register");
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] string login, [FromBody] string password)
        {
            var message = uService.RegisterUser(login, password);
            TempData["Message"] = message;
            return RedirectToAction("index");
        }

        [HttpGet("login")]
        public IActionResult LoginUser()
        {
            /*var user = new LoggedUser();*/ // HACK only default user login
            var message = uService.LoginUser(/*user*/); // HACK only default user login
            TempData["Message"] = message;
            return RedirectToAction("index");
        }

        [HttpGet("user")]
        public IActionResult UserData()
        {
            var newUserData = uService.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(newUserData.ApiKey);
            return View("user", new IndexViewModel(newUserData));
        }

        [HttpGet("update")]
        public IActionResult UpdateUser()
        {
            var userData = uService.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(userData.ApiKey);
            return View("update", new IndexViewModel(userData));
        }

        [HttpPost("update")]
        public IActionResult UpdatedUser([FromForm] string userName, [FromForm] string avatarUrl)
        {
            uService.UpdateUser(userName, avatarUrl);
            var newUserData = uService.GetUserData();
            ViewBag.LoggedUser = !String.IsNullOrEmpty(newUserData.ApiKey);
            return View("user", new IndexViewModel(newUserData));
        }

        [HttpGet("logout")]
        public IActionResult LogoutUser()
        {
            var message = uService.LogoutUser();
            TempData["Message"] = message;
            return RedirectToAction("index");
        }

        [HttpPost("postmessage")]
        public IActionResult PostMessage([FromForm] string content)
        {
            var postedMessage = mService.PostMessage(content);
            TempData["Message"] = postedMessage.Created.HasValue ? "Message was not sent" : "Message sent successfully";

            return RedirectToAction("index");
        }
    }
}