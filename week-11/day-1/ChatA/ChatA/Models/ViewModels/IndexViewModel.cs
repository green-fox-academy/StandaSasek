using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatA.Models.Entities;
using ChatA.Services;

namespace ChatA.Models.ViewModels
{
    public class IndexViewModel
    {
        public LoggedUser MyLoggedUser { get; set; }
        public IndexViewModel(LoggedUser myLoggedUser)
        {
            MyLoggedUser = myLoggedUser;
        }
        public IndexViewModel()
        {
        }
    }
}
