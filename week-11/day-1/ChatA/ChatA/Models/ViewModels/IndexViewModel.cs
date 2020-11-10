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
        public User MyUser { get; set; }
        public LoggedUser MyLoggedUser { get; set; }
        public IndexViewModel(User myUser, LoggedUser myLoggedUser)
        {
            MyUser = myUser;
            MyLoggedUser = myLoggedUser;
        }
        public IndexViewModel()
        {
        }
        public IndexViewModel(LoggedUser myLoggedUser)
        {
            MyLoggedUser = myLoggedUser;
        }
    }
}
