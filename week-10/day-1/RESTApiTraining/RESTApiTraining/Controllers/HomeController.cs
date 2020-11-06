using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Routing;
using RESTApiTraining.Models;
using RESTApiTraining.Services;

namespace RESTApiTraining.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly Service service;
        public HomeController(Service service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            service.CreateLog(new LogEntry(DateTime.Now, "index", ""));
            return File("index.html", "text/html");
        }
        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery]int? input)
        {
            service.CreateLog(new LogEntry(DateTime.Now, "doubling", "input=" + Convert.ToString(input))); // input.ToString() is better to use Convert.ToString(input) - handles null int
            if (input is null)
            {
                return BadRequest(new { error = "Please provide an input!" });
            }
            var result = input * 2;
            return Json(new Data(input.Value, result.Value)); // version with object
            // return Json(new { received = input, result = result });
        }
        [HttpPost("dountil/{operation}")]
        public IActionResult DoUntil([FromRoute] string operation, [FromBody] Operation until)
        {
            service.CreateLog(new LogEntry(DateTime.Now, "dountil", "operation=" + operation + "&" + "number=" + until?.Until.ToString()));
            if (until == null || !until.Until.HasValue) // TODO until.Until is null OR !until.Until.HasValue
            {
                return BadRequest(new { error = "Please provide a number!" });
            }
            var result = DoUntil(operation, until);
            return Ok(new { result = result });
        }
        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            service.CreateLog(new LogEntry(DateTime.Now, "greeter", "name=" + name + "&" + "title=" + title));
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(title))
            {
                return StatusCode(400, new { error = "Please provide a name and a title!" });
            }
            else if (String.IsNullOrEmpty(name))
            {
                return StatusCode(400, new { error = "Please provide a name!" });
            }
            else if (String.IsNullOrEmpty(title))
            {
                return StatusCode(400, new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }
        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            service.CreateLog(new LogEntry(DateTime.Now, "appenda", "appendable=" + (appendable == null ? "" : appendable)));
            var result = appendable + "a";
            return Json(new { appended = result });
        }
        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody]Arrays whatArray)
        {
            service.CreateLog(new LogEntry(DateTime.Now, "arrays", "what=" + whatArray.What + "&" + "numbers=" + String.Join(",", whatArray.Numbers)));
            if (whatArray.Numbers.Count == 0 || String.IsNullOrEmpty(whatArray.What))
            {
                return BadRequest(new { error = "Please provide what to do with the numbers!" });
            }
            var numbers = new List<int>(whatArray.Numbers);
            string operation = whatArray.What;
            var result = 0;
            if (operation == "sum")
            {
                foreach (var number in numbers)
                {
                    result += number;
                }
                return Json(new { result = result });
            }
            else if (operation == "multiply")
            {
                result++;
                foreach (var number in numbers)
                {
                    result *= number;
                }
                return Json(new { result = result });
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] += numbers[i];
                }
                return Json(new { result = numbers });
            }
        }
        [HttpGet("log")]
        public IActionResult GetLog()
        {
            service.CreateLog(new LogEntry(DateTime.Now, "log", ""));
            var listOfEntries = service.ListAllLogEntries();
            var numberOfLogs = listOfEntries.Count();
            return Json(new { entries = listOfEntries, entry_count = numberOfLogs });
        }
       /* [HttpPost("sith")]
        public IActionResult Sith([FromBody]SithTalk text)
        {
            service.CreateLog(new LogEntry(DateTime.Now, "sith", text.Text));
            if (String.IsNullOrEmpty(text.Text))
            {
                return BadRequest(new { error = "Feed me some text you have to, padawan young you are. Hmmm." });
            }
            var sithText = text.Text.Split(' ').ToList();
            service.YodaTalk(sithText);
            return Json(new { sith_text = translated });
        }*/
    }
}
