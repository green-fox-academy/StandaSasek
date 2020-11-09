using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatA.Models.Entities;

namespace ChatA.Database
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<User> ChatUsers { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<Entity>()
                .HasOne<User>(post => post.Author)
                .WithMany(user => user.Posts)
                .HasForeignKey(post => post.UserId)
                .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Vote>()
                 .HasOne<Entity>(vote => vote.Post)
                 .WithMany(post => post.Votes)
                 .HasForeignKey(vote => vote.PostId)
                 .OnDelete(DeleteBehavior.Cascade);

             modelBuilder.Entity<Vote>()
                 .HasOne<User>(vote => vote.User)
                 .WithMany(user => user.Votes)
                 .HasForeignKey(vote => vote.UserId)
                 .OnDelete(DeleteBehavior.Restrict);*/
        }
    }
}
