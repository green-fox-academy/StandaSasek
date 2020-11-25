using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public Librarian CategorizedBy { get; set; }
        public int CategorizedById { get; set; }
        public Book CategorizedBook { get; set; }
        public int CategorizedBookId { get; set; }
        public DateTime CategorizedAt { get; set; }

        public Category()
        {
        }
    }
}
