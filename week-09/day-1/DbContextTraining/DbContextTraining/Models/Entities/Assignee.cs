using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbContextTraining.Models.Entities
{
    public class Assignee
    {
        [Key]
        public int Id { get; set; }
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
