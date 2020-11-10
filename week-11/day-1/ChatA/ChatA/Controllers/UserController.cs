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

            return View();
        }
        /* [HttpGet("register")]
         public IActionResult RegisterUser()
         {
             return View("register");
         }
         [HttpPost("register")]
         public IActionResult RegisterUser([FromBody] string login, [FromBody] string password)
         {
             service.RegisterUser(login, password);

             return View("index");
         }*/
        [HttpGet("login")]
        public IActionResult LoginUser()
        {
            var user = new User();
            var message = service.LoginUser(user);
            ViewBag.Message = message;
            return View("index");
        }
        /*[HttpPost("login")]
        public IActionResult LogedUser([FromBody] string login, [FromBody] string password)
        {
            service.LoginUser(login, password);

            return View("index");
        }*/
        [HttpGet("user")]
        public IActionResult UserData()
        {

            return View("user");
        }
        [HttpGet("update")]
        public IActionResult UpdateUser()
        {
            return View("update");
        }
        [HttpPost("update")]
        public IActionResult UpdatedUser([FromBody] string userName, [FromBody]string avatarUrl)
        {
            service.UpdateUser(userName, avatarUrl);

            return View("user");
        }
    }
}
