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
    }
}
