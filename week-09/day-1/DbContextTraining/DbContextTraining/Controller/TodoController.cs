using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Database;
using DbContextTraining.Models;
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
        public IActionResult Index(/*long id,*/ bool IsNotDone)
        {
            if (IsNotDone is true)
            {
                var todos = service.ReadAllTodos(IsNotDone);
                return View("index", new IndexViewModels(todos));
            }
            /*else if (id != 0)
            {
                var todo = service.ReadTodo(id);
                return View("index", new IndexViewModels(todo));
            }*/
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
