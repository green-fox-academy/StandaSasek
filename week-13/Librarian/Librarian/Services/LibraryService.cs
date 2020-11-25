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
    }
}
