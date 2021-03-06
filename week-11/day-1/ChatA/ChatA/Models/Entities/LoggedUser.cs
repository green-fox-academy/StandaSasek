﻿namespace ChatA.Models.Entities
{
    public class LoggedUser
    {
        public string ApiKey { get; set; }
        public string Login { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AvatarUrl { get; set; }

        public LoggedUser()
        {
        }

        public LoggedUser(string apiKey, string userName, string avatarUrl, string login, string password)
        {
            ApiKey = apiKey;
            Login = login;
            UserName = userName;
            Password = password;
            AvatarUrl = avatarUrl;
        }
    }
}