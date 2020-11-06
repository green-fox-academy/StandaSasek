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
/*        public void CreateReport(Report entity)
        {
            dbContext.Entities.Add(entity);
            dbContext.SaveChanges();
        }
        public List<Report> ReadAllEntities()
        {
            return dbContext.Entities.ToList();
        }
        public void UpdateEntity(Report entityToUpdate)
        {
            dbContext.Update(entityToUpdate);
            dbContext.SaveChanges();
        }
        public void DeleteEntity(string name)
        {
            dbContext.Entities.Remove(dbContext.Entities.FirstOrDefault(p => p.Name.Equals(name)));
            dbContext.SaveChanges();
        }*/
    }
}
