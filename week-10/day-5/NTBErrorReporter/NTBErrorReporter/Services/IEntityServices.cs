using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NTBErrorReporter.Models.Entities;

namespace NTBErrorReporter.Services
{
    public interface IEntityServices
    {
        public void CreateEntity(Entity entity);
        public List<Entity> ReadAllEntities();
        public void UpdateEntity(Entity entityToUpdate);
        public void DeleteEntity(string name);
    }
}
