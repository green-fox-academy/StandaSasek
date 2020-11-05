using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApp.Services;
using TodoApp.Models.Entities;

namespace TodoApp.Models
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
        public IndexViewModels(Todo myTodo, List<Assignee> myAssignees)
        {
            MyTodo = myTodo;
            MyAssignees = myAssignees;
        }
        public IndexViewModels(List<Assignee> myAssignees, Assignee myAssignee)
        {
            MyAssignees = myAssignees;
            MyAssignee = myAssignee;
        }
        public IndexViewModels(List<Assignee> myAssignees)
        {
            MyAssignees = myAssignees;
        }
        public IndexViewModels(Assignee myAssignee)
        {
            MyAssignee = myAssignee;
        }
    }
}
