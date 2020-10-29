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

       /* public List<Todo> ReadAllTodos()
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .ToList();
        }*/
        public List<Todo> ReadAllTodos(bool isNotDone = false)
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .Where(t => !isNotDone || !t.IsDone)
                .ToList();
        }
        public List<Todo> ReadAllTodosAssignedTo(long assigneeid, bool isNotDone = false)
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .Where(t => isNotDone ? !t.IsDone : true)
                .Where(t => assigneeid != 0 ? t.AssigneeId.Equals(assigneeid) : true)
                .ToList();
        }
        public List<Assignee> ReadAllAssignees()
        {
            return dbContext.Assignees.ToList();
        }

        public List<Todo> SearchAllTodos(string search, bool isNotDone = false, long assigneeid = 0)
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .Where(t => t.Title.ToLower().Contains(search.ToLower()) || t.Description.ToLower().Contains(search.ToLower()))
                .Where(t => isNotDone ? !t.IsDone : true)
                .Where(t => assigneeid != 0 ? t.AssigneeId.Equals(assigneeid) : true)
                .ToList();
        }

      /*  public List<Todo> SearchNotDoneTodos(string search)
        {
            return dbContext.Todos.Include(ass => ass.Assignee)
                .Where(t => !t.IsDone).Where(t => t.Title.ToLower().Contains(search.ToLower()) || t.Description.ToLower().Contains(search.ToLower()))
                .ToList();
        }*/

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
            dbContext.Update(todoToUpdate);
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