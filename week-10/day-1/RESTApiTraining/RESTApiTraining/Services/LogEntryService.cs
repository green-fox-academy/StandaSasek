using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTApiTraining.Database;
using RESTApiTraining.Models;

namespace RESTApiTraining.Services
{
    public class LogEntryService : ILogEntryService
    {
        private readonly ApplicationDbContext dbContext;
        public LogEntryService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateLog(LogEntry logEntry)
        {
            dbContext.LogEntries.Add(logEntry);
            dbContext.SaveChanges();
        }
        public List<LogEntry> ListAllLogEntries()
        {
            return dbContext.LogEntries.ToList();
        }
    }
}
