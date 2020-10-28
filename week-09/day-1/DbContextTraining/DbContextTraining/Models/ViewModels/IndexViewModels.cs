using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DbContextTraining.Services;

namespace DbContextTraining.Models
{
    public class IndexViewModels
    {
        public List<Todo> MyTodos { get; set; }
        public Todo MyTodo { get; set; }
        public IndexViewModels(List<Todo> myTodos, Todo myTodo)
        {
            MyTodos = myTodos;
            MyTodo = myTodo;
        }
        public IndexViewModels()
        {
        }
        public IndexViewModels(List<Todo> myTodos)
        {
            MyTodos = myTodos;
        }
        public IndexViewModels(Todo myTodo)
        {
            MyTodo = myTodo;
        }
    }
}
