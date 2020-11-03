using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTApiTraining.Models;

namespace RESTApiTraining.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<LogEntry> LogEntries { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        
    }
}
