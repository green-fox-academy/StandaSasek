using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatA.Models.Entities
{
    public class User
    {
        public string Login { get; set; } = "Standa";
        public string Password { get; set; } = "pass";

        public User(string login , string password )
        {
            Login = login;
            Password = password;
        }
        public User()
        {
        }
    }
}
