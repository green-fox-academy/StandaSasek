using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NTBErrorReporter.Models.Entities;

namespace NTBErrorReporter.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<Entity> MyEntities { get; set; }
        public Entity MyEntity { get; set; }
        public IndexViewModel(List<Entity> myEntities, Entity myEntity)
        {
            MyEntities = myEntities;
            MyEntity = myEntity;
        }
        public IndexViewModel()
        {
        }

    }
}
