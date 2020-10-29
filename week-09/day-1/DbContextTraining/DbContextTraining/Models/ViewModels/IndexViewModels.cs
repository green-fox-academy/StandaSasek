using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DbContextTraining.Services;
using DbContextTraining.Models.Entities;

namespace DbContextTraining.Models
{
    public class IndexViewModels
    {
        public List<Todo> MyTodos { get; set; }
        public Todo MyTodo { get; set; }
        public List<Assignee> MyAssignees { get; set; }
        public Assignee MyAssignee { get; set; }
        public IndexViewModels(List<Todo> myTodos, Todo myTodo, List<Assignee> myAssignees, Assignee myAssignee)
        {
            MyTodo = myTodo;
            MyTodos = myTodos;
            MyAssignees = myAssignees;
            MyAssignee = myAssignee;
        }
        public IndexViewModels()
        {
        }
        public IndexViewModels(List<Todo> myTodos)
        {
            MyTodos = myTodos;
        }
        public IndexViewModels(List<Todo> myTodos, List<Assignee> myAssignees)
        {
            MyAssignees = myAssignees;
            MyTodos = myTodos;
        }
        public IndexViewModels(Todo myTodo)
        {
            MyTodo = myTodo;
        }
    }
}
