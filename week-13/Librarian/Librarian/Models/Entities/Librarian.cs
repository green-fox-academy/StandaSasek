using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Models.Entities
{
    public class Librarian
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Book> RegisteredBooks { get; set; }
        public List<Category> CategorizedBooks { get; set; }

        public Librarian()
        {
        }
    }
}
