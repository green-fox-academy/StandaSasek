using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Database;
using DbContextTraining.Models;
using DbContextTraining.Models.Entities;
using DbContextTraining.Services;
using Microsoft.AspNetCore.Mvc;

namespace DbContextTraining.Controllers
{
    [Route("")]
    public class AssigneeController : Controller
    {
        private readonly IAssigneeService service;

        public AssigneeController(IAssigneeService service)
        {
            this.service = service;
        }
        [HttpGet("assignees")]
        public IActionResult Assignees()
        {
            var assignees = service.ReadAllAssignees();
            return View("assignees", new IndexViewModels(assignees));
        }
        [HttpGet("create-assignee")]
        public IActionResult CreateAssignee()
        {
            return View("create-assignee");
        }
        [HttpPost("create-assignee")]
        public IActionResult CreatedAssignee(Assignee assignee)
        {
            service.CreateAssignee(assignee);
            return RedirectToAction("assignees");
        }
        [HttpPost("delete-assignee")]
        public IActionResult DeleteAssignee(long id)
        {
            service.DeleteAssignee(id);
            return RedirectToAction("assignees");
        }
        [HttpGet("update-assignee")]
        public IActionResult UpdateAssignee(long id)
        {
            var assignee = service.ReadAssignee(id);
            return View("update-assignee", new IndexViewModels(assignee));
        }
        [HttpPost("update-assignee")]
        public IActionResult UpdatedAssignee(Assignee assignee)
        {
            service.UpdateAssignee(assignee);
            return RedirectToAction("assignees");
        }
    }
}
