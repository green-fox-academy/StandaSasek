using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbContextTraining.Models.Entities;

namespace DbContextTraining.Services
{
    public interface IAssigneeService
    {
        public List<Assignee> ReadAllAssignees();
        public void CreateAssignee(Assignee assignee);
        public Assignee ReadAssignee(long id);
        public void UpdateAssignee(Assignee assignee);
        public void DeleteAssignee(long id);
    }
}
