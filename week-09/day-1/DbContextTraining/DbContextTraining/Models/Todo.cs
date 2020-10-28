using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbContextTraining.Models
{
    public class Todo
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public Todo(long id, string title, string description, bool isUrgent = false, bool isDone = false)
        {
            Id = id;
            Title = title;
            Description = description;
            IsUrgent = isUrgent;
            IsDone = isDone;
        }
        public Todo()
        {
        }
    }
}
