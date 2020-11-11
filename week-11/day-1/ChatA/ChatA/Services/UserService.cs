using System;
using System.Net.Http;
using System.Text;
using ChatA.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChatA.Services
{
    public class UserService
    {
        const string urlUserApi = "https://latest-chat.herokuapp.com/api/user";
        private readonly HttpClient httpClient;
        private static string ActualApiKey { get; set; }

        public UserService(IHttpClientFactory clientFactory)
        {
            httpClient = clientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("apikey", ActualApiKey);
        }

        internal string GenericRequest(string requestData, string urlString)
        {
            var httpContent = new StringContent(requestData, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync((urlUserApi + urlString), httpContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }
        internal string RegisterUser(string login, string password)
        {
            var requestData = JsonConvert.SerializeObject(new { login = login, password = password });
            var urlString = "/register";
            var data = GenericRequest(requestData, urlString);
            var user = JsonConvert.DeserializeObject<LoggedUser>(data);

            return String.IsNullOrEmpty(user.Login) ? "User registration status: False" : "User registration status: OK";
        }
        internal string LoginUser(LoggedUser user)
        {
            var requestData = JsonConvert.SerializeObject(new { login = "Standa", password = "pass" }); // HACK only default user login
            var urlString = "/login";
            var data = GenericRequest(requestData, urlString);
            var loggedUser = JsonConvert.DeserializeObject<LoggedUser>(data);
            SaveUserStrings(loggedUser.ApiKey);

            return String.IsNullOrEmpty(loggedUser.ApiKey) ? "User not logged" : "User logged successfully";
        }
        internal LoggedUser UpdateUser(string userName, string avatarUrl)
        {
            var requestData = JsonConvert.SerializeObject(new { username = userName, avatarurl = avatarUrl });
            var urlString = "/update";
            var data = GenericRequest(requestData, urlString);
            var result = JsonConvert.DeserializeObject<LoggedUser>(data);

            return result;
        }
        internal string LogoutUser()
        {
            if (String.IsNullOrEmpty(ActualApiKey))
            {
                return "User logged out";
            }
            var requestData = "";
            var urlString = "/logout";
            var data = GenericRequest(requestData, urlString);
            var loggedUser = JsonConvert.DeserializeObject<string>(data);
            if (loggedUser == "true")
            {
                ActualApiKey = "";
            }

            return loggedUser == "true" ? "User logged out" : "User not logged out";
        }
        public void SaveUserStrings(string apiKey)
        {
            if (apiKey == ActualApiKey)
            {
                return;
            }
            ActualApiKey = apiKey;
        }
        public LoggedUser GetUserData()
        {
            if (String.IsNullOrEmpty(ActualApiKey))
            {
                return new LoggedUser();
            }
            var response = httpClient.GetAsync(urlUserApi).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            if (String.IsNullOrEmpty(data))
            {
                return new LoggedUser();
            }
            var loggedUser = JsonConvert.DeserializeObject<LoggedUser>(data);
            loggedUser.ApiKey = ActualApiKey;
            loggedUser.Login = loggedUser.Login;

            return loggedUser;
        }
    }
}
