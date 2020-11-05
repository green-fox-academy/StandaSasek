using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models.Entities
{
    public class Assignee
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Todo> Todos { get; set; }
        public Assignee(string name, string email, List<Todo> todos)
        {
            Name = name;
            Email = email;
            Todos = todos;
        }
        public Assignee()
        {
        }
    }
}
