using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTBErrorReporter.Database;
using NTBErrorReporter.Models.Entities;

namespace NTBErrorReporter.Services
{
    public class ReportService // TODO decide if need of Interface
    {
        private readonly ApplicationDbContext dbContext;

        public ReportService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateReport(Report report)
        {
            dbContext.Reports.Add(report);
            dbContext.SaveChanges();
        }
        //TODO delete unneeded methods
        public List<Report> ReadAllReports()
        {
            return dbContext.Reports.ToList();
        }
        public List<Report> ReadAllReports(Search keyWord)
        {
            var manufacturer = keyWord.Manufacturer;
            return dbContext.Reports.Where(r => r.Manufacturer.Equals(keyWord.Manufacturer) || r.ReporterName.Name.Equals(keyWord.Reporter)).ToList();
        }
        public Report ReadReport(int id)
        {
            return dbContext.Reports
                .Include(name => name.ReporterName)
                .FirstOrDefault(r => r.Id.Equals(id));
        }
        public List<Reporter> ReadAllReporters()
        {
            return dbContext.Reporter.ToList();
        }
        public Reporter ReadReporter(int id)
        {
            return dbContext.Reporter.FirstOrDefault(r => r.Id.Equals(id));
        }
        public void DeleteReport(int id)
        {
            dbContext.Reports.Remove(dbContext.Reports.FirstOrDefault(r => r.Id.Equals(id)));
            dbContext.SaveChanges();
        }
    }

    /*public void UpdateEntity(Report entityToUpdate)
{
dbContext.Update(entityToUpdate);
dbContext.SaveChanges();
}
*/
}

