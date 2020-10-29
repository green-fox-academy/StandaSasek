﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Models;
using DbContextTraining.Models.Entities;

namespace DbContextTraining.Services
{
    public interface ITodoService
    {
        public List<Todo> ReadAllTodos(bool isNotDone = false);
        public List<Todo> ReadAllTodosAssignedTo(long assigneeid, bool isNotDone = false);
        public List<Assignee> ReadAllAssignees();
        public void CreateTodo(Todo todo);
        public Todo ReadTodo(long id);
        public List<Todo> SearchAllTodos(string search, bool isNotDone = false, long assigneeid = 0);
        public void UpdateTodo(Todo todoToModify);
        public void DeleteTodo(long id);
    }
}
