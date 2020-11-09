using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatA.Database;
using ChatA.Models.Entities;

namespace ChatA.Services
{
    public class UserServices
    {
        private readonly ApplicationDbContext dbContext;

        public UserServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateEntity(User user)
        {
            dbContext.ChatUsers.Add(user);
            dbContext.SaveChanges();
        }
        public User ReadUser(int userId)
        {
            return dbContext.ChatUsers.FirstOrDefault(u => u.UserId.Equals(userId)); ;
        }
        /*public void UpdateEntity(User entityToUpdate)
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
