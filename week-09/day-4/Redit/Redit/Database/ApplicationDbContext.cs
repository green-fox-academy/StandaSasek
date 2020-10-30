using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Redit.Models.Entities;

namespace Redit.Database
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User> Votes { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
               .HasOne<User>(post => post.Author)
               .WithMany(user => user.Posts)
               .HasForeignKey(post => post.UserId);

            modelBuilder.Entity<Vote>()
                .HasOne<Post>(vote => vote.Post)
                .WithMany(post => post.Votes)
                .HasForeignKey(vote => vote.PostId);

            modelBuilder.Entity<Vote>()
                .HasOne<User>(vote => vote.User)
                .WithMany(user => user.Votes)
                .HasForeignKey(vote => vote.UserId);
        }
    }
}
