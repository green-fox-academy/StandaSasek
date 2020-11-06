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
            return View(new IndexViewModel(reporters));
        }
        [HttpPost("report")]
        public IActionResult CreateReport(int reporterId, string manufacturer, string serialnumber, string description)
        {
            var dbReporter = service.ReadReporter(reporterId);
            var report = new Report(dbReporter, reporterId, manufacturer, serialnumber, description);
            service.CreateReport(report);
            return RedirectToAction("list");
        }
        [HttpGet("list")]
        public IActionResult List()
        {
            var reporters = service.ReadAllReporters();
            var reports = service.ReadAllReports();
            return View(new IndexViewModel(reports, reporters));
        }
        [HttpPost("complete/{id}")]
        public IActionResult DeleteReport([FromRoute] int? id, [FromBody] SecretWord secret)
        {
            if (secret == null || String.IsNullOrEmpty(secret.Secret))
            {
                return BadRequest(new { error = "Missing the right word!" });
            }
            else if (id == null)
            {
                return BadRequest(new { error = "Missing the right number!" });
            }
            else if (secret.Secret.Equals("voala"))
            {
                service.DeleteReport((int)id);
            }
            return Ok();
        }
        [HttpGet("list/query")]
        public IActionResult ListQuery([FromQuery] Search keyWord)
        {
            if (keyWord == null || (String.IsNullOrEmpty(keyWord.Manufacturer) && String.IsNullOrEmpty(keyWord.Reporter)))
            {
                return BadRequest(new { error = "Missing the Manufacturer name or Name who reported!" });
            }
            var listByKeyword = service.ReadAllReports(keyWord);
            return Ok(new { result = "ok", tickets = listByKeyword });
        }
    }
}
