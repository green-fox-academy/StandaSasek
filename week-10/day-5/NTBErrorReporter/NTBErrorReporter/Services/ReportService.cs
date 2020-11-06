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
            /*var dbReport = ReadReport(report.Id);
           
            dbReport.ReporterName = dbReporter;
            dbReport.ReporterId = dbReporter.Id;
            dbReport.Manufacturer = report.Manufacturer;
            dbReport.SerialNumber = report.SerialNumber;
            dbReport.Description = report.Description;*/
            dbContext.Reports.Add(report);
            dbContext.SaveChanges();
        }
        //TODO delete unneeded methods
        public List<Report> ReadAllReports()
        {
            return dbContext.Reports.ToList();
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
        /*public void UpdateEntity(Report entityToUpdate)
        {
            dbContext.Update(entityToUpdate);
            dbContext.SaveChanges();
        }
        public void DeleteEntity(string name)
        {
            dbContext.Entities.Remove(dbContext.Entities.FirstOrDefault(p => p.Name.Equals(name)));
            dbContext.SaveChanges();
        }
    }*/
    }
}
