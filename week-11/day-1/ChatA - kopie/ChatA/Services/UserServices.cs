using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatA.Models.Entities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace ChatA.Services
{
    public class UserServices
    {
        const string urlApi = "https://latest-chat.herokuapp.com/api";
        private readonly IHttpClientFactory clientFactory;
        private static string ActualApiKey { get; set; }
        private static string ActualLogin { get; set; }
        private static string ActualPassword { get; set; }

        public UserServices(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        internal User RegisterUser(string login, string password)
        {
            var userRegister = JsonConvert.SerializeObject(new { login = login, password = password });
            var httpContent = new StringContent(userRegister, Encoding.UTF8, "application/json");

            var response = clientFactory.CreateClient().PostAsync(urlApi + "api/user/register", httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<User>(data);

            return result;
        }
        internal User LoginUser(string login, string password)
        {
            var userLogin = JsonConvert.SerializeObject(new { login = login, password = password });
            var httpContent = new StringContent(userLogin, Encoding.UTF8, "application/json");

            var response = clientFactory.CreateClient().PostAsync(urlApi + "api/user/register", httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<User>(data);
            SaveUserStrings(login, password, result.ApiKey);

            return result;
        }
        internal User UpdateUser(User user)
        {
            var userUpdate = JsonConvert.SerializeObject(new { user });
            var httpContent = new StringContent(userUpdate, Encoding.UTF8, "application/json");
            httpContent.Headers.Add("apiKey", ActualApiKey);

            var response = clientFactory.CreateClient().PostAsync(urlApi + "api/user/update", httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<User>(data);
            if (user.Password != ActualPassword)
            {
                ActualPassword = user.Password;
            }

            return result;
        }
        public void SaveUserStrings(string login, string password, string apiKey)
        {
            if (String.IsNullOrEmpty(ActualApiKey) || apiKey != ActualApiKey)
            {
                ActualApiKey = apiKey;
            }
            ActualLogin = login;
            ActualPassword = password;
        }

    }
}
