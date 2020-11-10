﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatA.Models.Entities;

namespace ChatA.Models.ViewModels
{
    public class IndexViewModel
    {
        public User MyUser { get; set; }
        public IndexViewModel(User myUser)
        {
            MyUser = myUser;
        }
        public IndexViewModel()
        {
        }

    }
}
