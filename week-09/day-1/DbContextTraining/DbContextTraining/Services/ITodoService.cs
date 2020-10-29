using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Models;
using DbContextTraining.Models.Entities;

namespace DbContextTraining.Services
{
    public interface ITodoService
    {
        public List<Todo> ReadAllTodos();
        public void CreateTodo(Todo todo);
        public Todo ReadTodo(long id);
        public List<Todo> ReadAllTodos(bool isActive);
        public List<Todo> SearchAllTodos(string search);
        public List<Todo> SearchNotDoneTodos(string search);
        public void UpdateTodo(Todo todoToModify);
        public void DeleteTodo(long id);
    }
}
