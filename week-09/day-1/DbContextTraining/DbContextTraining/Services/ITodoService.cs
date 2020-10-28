using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Models;

namespace DbContextTraining.Services
{
    public interface ITodoService
    {
        public List<Todo> ReadAllTodos();
        public void CreateTodo(Todo todo);
        public Todo ReadTodo(long id);
        public List<Todo> ReadAllTodos(bool isActive);
        public void UpdateTodo(Todo todoToModify);
        public void DeleteTodo(long id);
    }
}
