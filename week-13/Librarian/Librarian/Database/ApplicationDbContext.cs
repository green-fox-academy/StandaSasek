using LibrarianSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Librarian> Librarians { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }*/
    }
}
