using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTBErrorReporter.Models.Entities;

namespace NTBErrorReporter.Database
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Report> Reports { get; set; }
        public DbSet<Reporter> Reporter { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Report>()
               .HasOne<Reporter>(report => report.ReporterName)
               .WithMany(reporter => reporter.Reports)
               .HasForeignKey(report => report.ReporterId)
               /*.OnDelete(DeleteBehavior.Restrict)*/;
/*
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
