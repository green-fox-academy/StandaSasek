using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Models;
using DbContextTraining.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbContextTraining.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasOne<Assignee>(todo => todo.Assignee)
                .WithMany(assignee => assignee.Todos).HasForeignKey(todo => todo.AssigneeId);
        }
    }
}
