using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Database;
using DbContextTraining.Models;
using DbContextTraining.Models.Entities;
using DbContextTraining.Services;
using Microsoft.AspNetCore.Mvc;

namespace DbContextTraining
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
            var todos = service.ReadAllTodos();
            return View("index", new IndexViewModels(todos));
        }
        [HttpPost("")]
        public IActionResult Index(bool isNotDone, string search)
        {
            if (!String.IsNullOrEmpty(search) && isNotDone)
            {
                var todos = service.SearchNotDoneTodos(search);
                return View("index", new IndexViewModels(todos));
            }
            else if (!String.IsNullOrEmpty(search))
            {
                var todos = service.SearchAllTodos(search);
                return View("index", new IndexViewModels(todos));
            }
            else if (isNotDone)
            {
                var todos = service.ReadAllTodos(isNotDone);
                return View("index", new IndexViewModels(todos));
            }
            else
            {
                var todos = service.ReadAllTodos();
                return View("index", new IndexViewModels(todos));
            }
        }
        [HttpGet("create")]
        public IActionResult CreateTodo()
        {
            var todos = service.ReadAllTodos();
            return View("create", new IndexViewModels(todos));
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
            var todo = service.ReadTodo(id);
            return View("update", new IndexViewModels(todo));
        }
        [HttpPost("update")]
        public IActionResult UpdatedTodo(Todo todo)
        {
            service.UpdateTodo(todo);
            return RedirectToAction("index");
        }
    }
}
