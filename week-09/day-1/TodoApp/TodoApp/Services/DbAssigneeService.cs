using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Database;
using TodoApp.Models.Entities;

namespace TodoApp.Services
{
    public class DbAssigneeService : IAssigneeService
    {
        private readonly ApplicationDbContext dbContext;

        public DbAssigneeService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateAssignee(Assignee assignee)
        {
            dbContext.Assignees.Add(assignee);
            dbContext.SaveChanges();
        }

        public void DeleteAssignee(long id)
        {
            dbContext.Assignees.Remove(dbContext.Assignees
                 .FirstOrDefault(t => t.Id.Equals(id)));
            dbContext.SaveChanges();
        }

        public List<Assignee> ReadAllAssignees()
        {
            return dbContext.Assignees.ToList();
        }

        public Assignee ReadAssignee(long id)
        {
            return dbContext.Assignees.
                FirstOrDefault(t => t.Id.Equals(id));
        }

        public void UpdateAssignee(Assignee assignee)
        {
            dbContext.Update(assignee);
            dbContext.SaveChanges();
        }
    }
}
