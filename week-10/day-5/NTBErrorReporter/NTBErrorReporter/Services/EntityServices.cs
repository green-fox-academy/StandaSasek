using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTBErrorReporter.Database;
using NTBErrorReporter.Models.Entities;

namespace NTBErrorReporter.Services
{
    public class EntityServices : IEntityServices
    {
        private readonly ApplicationDbContext dbContext;

        public EntityServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateEntity(Entity entity)
        {
            dbContext.Entities.Add(entity);
            dbContext.SaveChanges();
        }
        public List<Entity> ReadAllEntities()
        {
            return dbContext.Entities.ToList();
        }
        public void UpdateEntity(Entity entityToUpdate)
        {
            dbContext.Update(entityToUpdate);
            dbContext.SaveChanges();
        }
        public void DeleteEntity(string name)
        {
            dbContext.Entities.Remove(dbContext.Entities.FirstOrDefault(p => p.Name.Equals(name)));
            dbContext.SaveChanges();
        }
    }
}
