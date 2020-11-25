using Authorize.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorize.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<User> MyEntities { get; set; }
        public User MyEntity { get; set; }
        public IndexViewModel(List<User> myEntities, User myEntity)
        {
            MyEntities = myEntities;
            MyEntity = myEntity;
        }
        public IndexViewModel()
        {
        }

    }
}
