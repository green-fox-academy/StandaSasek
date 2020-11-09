using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatA.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ApiKey { get; set; }
        public string Login { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AvatarUrl { get; set; }

        public User()
        {
        }
        public User(int userId, string apiKey, string login, string userName, string password, string avatarUrl)
        {
            UserId = userId;
            ApiKey = apiKey;
            Login = login;
            UserName = userName;
            Password = password;
            AvatarUrl = avatarUrl;
        }
    }
}
