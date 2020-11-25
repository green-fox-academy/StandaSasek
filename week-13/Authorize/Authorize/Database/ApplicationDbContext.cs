using Microsoft.EntityFrameworkCore;
using Authorize.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorize.Database
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            Users.Add(new User { Password = "pepa", UserName = "pepa" });
            SaveChanges();
        }
    }
}
