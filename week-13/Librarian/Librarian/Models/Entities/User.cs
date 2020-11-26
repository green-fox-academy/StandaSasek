using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Registered { get; set; }
        public List<Borrow> BorrowedBooks { get; set; }
        public List<Book> RegisteredBooks { get; set; }
        public List<Category> CategorizedBooks { get; set; }
        public bool Librarian { get; set; }

        public User()
        {
        }

        public User(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }
    }
}
