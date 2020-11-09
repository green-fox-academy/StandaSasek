using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatA.Database;
using ChatA.Models.Entities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace ChatA.Services
{
    public class UserServices
    {
        const string urlApi = "https://latest-chat.herokuapp.com/api";
        private readonly ApplicationDbContext dbContext;
        private readonly IHttpClientFactory clientFactory;

        public UserServices(ApplicationDbContext dbContext, IHttpClientFactory clientFactory)
        {
            this.dbContext = dbContext;
            this.clientFactory = clientFactory;
        }
        public UserServices()
        {
        }

        internal User RegisterUser(string login, string password)
        {
            var userRegister = JsonConvert.SerializeObject(new { login = login, password = password });
            var httpContent = new StringContent(userRegister, Encoding.UTF8, "application/json");

            var response = clientFactory.CreateClient().PostAsync(urlApi + "api/user/register", httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<User>(data);
            CreateUser(result);

            return result;
        }
        public void CreateUser(User user)
        {
            dbContext.ChatUsers.Add(user);
            dbContext.SaveChanges();
        }
        public User ReadUser(int userId)
        {
            return dbContext.ChatUsers.FirstOrDefault(u => u.UserId.Equals(userId));
        }
        internal User LoginUser(string login, string password)
        {
            var userLogin = JsonConvert.SerializeObject(new { login = login, password = password });
            var httpContent = new StringContent(userLogin, Encoding.UTF8, "application/json");

            var response = clientFactory.CreateClient().PostAsync(urlApi + "api/user/register", httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<User>(data);
            UpdateUserApiKey(result.UserId, result.ApiKey);

            return result;
        }
        public void UpdateUserApiKey(int userId, string apiKey)
        {
            var dbUser = dbContext.ChatUsers.FirstOrDefault(u => u.UserId.Equals(userId)); ;
            if (!dbUser.ApiKey.Equals(apiKey))
            {
                dbUser.ApiKey = apiKey;
                dbContext.Update(dbUser);
                dbContext.SaveChanges();
            }
        }
        /*
public void DeleteEntity(string name)
{
   dbContext.Entities.Remove(dbContext.Entities.FirstOrDefault(p => p.Name.Equals(name)));
   dbContext.SaveChanges();
}*/
    }
}
