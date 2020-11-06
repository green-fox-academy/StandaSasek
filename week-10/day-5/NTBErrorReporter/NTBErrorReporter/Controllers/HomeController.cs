using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NTBErrorReporter.Models.Entities;
using NTBErrorReporter.Models.ViewModels;
using NTBErrorReporter.Services;

namespace NTBErrorReporter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ReportService service;
        public HomeController(ReportService service)
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
