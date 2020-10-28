using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Database;
using DbContextTraining.Models;

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
            return dbContext.Todos.ToList();
        }
        public List<Todo> ReadAllTodos(bool IsNotDone)
        {
            return dbContext.Todos.Where(p => !p.IsDone).ToList();
        }
        public void CreateTodo(Todo todo)
        {
            dbContext.Todos.Add(todo);
            dbContext.SaveChanges();
        }
        public Todo ReadTodo(long id)
        {
            return dbContext.Todos.FirstOrDefault(p => p.Id.Equals(id));
        }
        public void UpdateTodo(Todo todoToUpdate)
        {
            var dbTodo = ReadTodo(todoToUpdate.Id);
            dbTodo.IsDone = todoToUpdate.IsDone;
            dbTodo.IsUrgent = todoToUpdate.IsUrgent;
            dbTodo.Title = todoToUpdate.Title;
            dbTodo.Description = todoToUpdate.Description;
            dbContext.SaveChanges();
        }
        public void DeleteTodo(long id)
        {
            dbContext.Todos.Remove(dbContext.Todos.FirstOrDefault(p => p.Id.Equals(id)));
            dbContext.SaveChanges();
        }
    }
}
