using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTApiTraining.Models;

namespace RESTApiTraining.Services
{
    public interface ILogEntryService
    {
        public void CreateLog(LogEntry logEntry);
        public List<LogEntry> ListAllLogEntries();
    }
}
