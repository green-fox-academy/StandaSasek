using System.Collections.Generic;
using System.Linq;
using DbContextTraining.Database;
using DbContextTraining.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbContextTraining.Services
{
    public class DbTodoService : ITodoService
    {
        private readonly ApplicationDbContext dbContext;

        public DbTodoService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Todo> ReadAllTodos()
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .ToList();
        }

        public List<Todo> ReadAllTodos(bool IsNotDone)
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .Where(t => !t.IsDone)
                .ToList();
        }

        public List<Todo> SearchAllTodos(string search)
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .Where(t => t.Title.ToLower().Contains(search.ToLower()) || t.Description.ToLower().Contains(search.ToLower()))
                .ToList();
        }

        public List<Todo> SearchNotDoneTodos(string search)
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .Where(t => !t.IsDone).Where(t => t.Title.ToLower().Contains(search.ToLower()) || t.Description.ToLower().Contains(search.ToLower()))
                .ToList();
        }

        public void CreateTodo(Todo todo)
        {
            dbContext.Todos.Add(todo);
            dbContext.SaveChanges();
        }

        public Todo ReadTodo(long id)
        {
            return dbContext.Todos.
                Include(ass => ass.Assignee).
                FirstOrDefault(t => t.Id.Equals(id));
        }

        public void UpdateTodo(Todo todoToUpdate)
        {
            var dbTodo = ReadTodo(todoToUpdate.Id);
            dbTodo.IsDone = todoToUpdate.IsDone;
            dbTodo.IsUrgent = todoToUpdate.IsUrgent;
            dbTodo.Title = todoToUpdate.Title;
            dbTodo.Description = todoToUpdate.Description;
            dbTodo.Assignee = todoToUpdate.Assignee;
            dbContext.SaveChanges();
        }

        public void DeleteTodo(long id)
        {
            dbContext.Todos.Remove(dbContext.Todos
                .FirstOrDefault(t => t.Id.Equals(id)));
            dbContext.SaveChanges();
        }
    }
}