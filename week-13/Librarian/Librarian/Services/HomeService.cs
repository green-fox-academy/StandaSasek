using LibrarianSystem.Database;
using LibrarianSystem.Models.Entities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LibrarianSystem.Services
{
    public class HomeService
    {
        private readonly ApplicationDbContext dbContext;

        public HomeService(ApplicationDbContext dbContext)
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
