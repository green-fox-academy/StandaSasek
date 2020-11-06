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
            var reporters = service.ReadAllReporters();
            var reports = service.ReadAllReports();
            return View(new IndexViewModel(reports, reporters));
        }
        [HttpPost("")]
        public IActionResult CreateReport(int reporterId, string manufacturer, string serialnumber, string description)
        {
            var dbReporter = service.ReadReporter(reporterId);
            var report = new Report(dbReporter, reporterId, manufacturer, serialnumber, description);
            service.CreateReport(report);
            return RedirectToAction("index");
        }

    }
}
