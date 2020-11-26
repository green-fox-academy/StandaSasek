using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public List<Category> Categories { get; set; }
        public DateTime Registered { get; set; }
        public User RegisteredBy { get; set; }
        public bool Destroyed { get; set; }
        public User Librarian { get; }

        public Book()
        {
        }

        public Book(string name, string author, User librarian)
        {
            Name = name;
            Author = author;
            Librarian = librarian;
        }
    }
}
