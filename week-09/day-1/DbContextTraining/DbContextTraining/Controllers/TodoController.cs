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
    public class TodoController : Controller
    {
        private readonly ITodoService service;
        public TodoController(ITodoService service)
        {
            this.service = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var assignees = service.ReadAllAssignees();
            var todos = service.ReadAllTodos();
            return View("index", new IndexViewModels(todos, assignees));
        }
        [HttpPost("")]
        public IActionResult Index(bool isNotDone, string search, long assigneeid = 0)
        {
            List<Todo> todos;
            if (!String.IsNullOrEmpty(search) && assigneeid != 0)
            {
                todos = service.SearchAllTodos(search, assigneeid, isNotDone);
            }
            else if (!String.IsNullOrEmpty(search))
            {
                todos = service.SearchAllTodos(search, isNotDone);
            }
            else if (assigneeid != 0)
            {
                todos = service.ReadAllTodosAssignedTo(assigneeid, isNotDone);
            }
            else
            {
                todos = service.ReadAllTodos(isNotDone);
            }
            var assignees = service.ReadAllAssignees();
            return View("index", new IndexViewModels(todos, assignees));
        }
        [HttpGet("create")]
        public IActionResult CreateTodo()
        {
            var assignees = service.ReadAllAssignees();
            return View("create", new IndexViewModels(assignees));
        }
        [HttpPost("create")]
        public IActionResult CreatedTodo(Todo todo)
        {
            service.CreateTodo(todo);
            return RedirectToAction("index");
        }
        [HttpGet("delete")]
        public IActionResult DeleteTodo(long id)
        {
            service.DeleteTodo(id);
            return RedirectToAction("index");
        }
        [HttpGet("update")]
        public IActionResult UpdateTodo(long id)
        {
            var assignees = service.ReadAllAssignees();
            var todo = service.ReadTodo(id);
            return View("update", new IndexViewModels(todo, assignees));
        }
        [HttpPost("update")]
        public IActionResult UpdatedTodo(Todo todo)
        {
            service.UpdateTodo(todo);
            return RedirectToAction("index");
        }
    }
}
