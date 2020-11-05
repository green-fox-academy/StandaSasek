using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;
using TodoApp.Models.Entities;

namespace TodoApp.Services
{
    public interface ITodoService
    {
        public List<Todo> ReadAllTodos(bool isNotDone = false);
        public List<Todo> ReadAllTodosAssignedTo(long assigneeid, bool isNotDone = false);
        public List<Assignee> ReadAllAssignees();
        public void CreateTodo(Todo todo);
        public Todo ReadTodo(long id);
        public List<Todo> SearchAllTodos(string search, long assigneeid, bool isNotDone = false);
        public List<Todo> SearchAllTodos(string search, bool isNotDone = false);
        public void UpdateTodo(Todo todoToModify);
        public void DeleteTodo(long id);
    }
}
