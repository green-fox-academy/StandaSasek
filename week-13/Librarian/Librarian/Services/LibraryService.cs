using LibrarianSystem.Database;
using LibrarianSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Services
{
    public class LibraryService
    {
        private readonly ApplicationDbContext dbContext;

        public LibraryService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User Login(string login, string password)
        {
            var entityUser = dbContext.Users.FirstOrDefault(u => u.Login.Equals(login) && u.Password.Equals(password));
            return entityUser;
        }
        internal bool RegisterUser(string name, string login, string password)
        {
            if (dbContext.Users.FirstOrDefault(u => u.Login.Equals(login)) != null)
            {
                return false;
            }
            var newUser = new User(name, login, password);
            newUser.Registered = DateTime.Now;
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();

            return true;
        }
        internal bool AddBook(string name, string author, User librarian) // TODO add some checking
        {
            var newBook = new Book(name, author, librarian);
            dbContext.Books.Add(newBook);
            dbContext.SaveChanges();

            return true;
        }
        internal User GetDefaultLibrarian()
        {
            var librarian = dbContext.Users.FirstOrDefault(u => u.Librarian);

            return librarian;
        }
        internal List<User> GetClients()
        {
            var clients = dbContext.Users.Where(u => !u.Librarian).ToList();

            return clients;
        }
        internal List<User> GetLibrarians()
        {
            var librarians = dbContext.Users.Where(u => u.Librarian).ToList();

            return librarians;
        }
    }
}
