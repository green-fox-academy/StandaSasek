using System;
using System.Net.Http;
using System.Text;
using ChatA.Models.Entities;
using Newtonsoft.Json;

namespace ChatA.Services
{
    public class UserServices
    {
        const string urlApi = "https://latest-chat.herokuapp.com/api/user";
        private readonly HttpClient httpClient;
        private static string ActualApiKey { get; set; }
        
        public UserServices(IHttpClientFactory clientFactory)
        {
            httpClient = clientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("apiKey", ActualApiKey);
        }

        internal string GenericRequest(string requestData, string urlString)
        {
            var httpContent = new StringContent(requestData, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync((urlApi + urlString), httpContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }
        internal User RegisterUser(string login, string password)
        {
            var userRegister = JsonConvert.SerializeObject(new { login = login, password = password });
            var httpContent = new StringContent(userRegister, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync((urlApi + "/register"), httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<User>(data);

            return result;
        }
        internal string LoginUser(User user)
        {
            var requestData = JsonConvert.SerializeObject(new { login = user.Login, password = user.Password }); ;
            var urlString = "/login";
            var data = GenericRequest(requestData, urlString);
            var loggedUser = JsonConvert.DeserializeObject<LoggedUser>(data);
            SaveUserStrings(loggedUser.ApiKey);

            return String.IsNullOrEmpty(loggedUser.ApiKey) ? "User login status: False" : "User login status: OK"; ;
        }
        internal LoggedUser UpdateUser(string userName, string avatarUrl)
        {
            var userUpdate = JsonConvert.SerializeObject(new { username = userName, avatarurl = avatarUrl });
            var httpContent = new StringContent(userUpdate, Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync((urlApi + "/update"), httpContent).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<LoggedUser>(data);

            return result;
        }
        public void SaveUserStrings(string apiKey)
        {
            if (String.IsNullOrEmpty(ActualApiKey) || apiKey != ActualApiKey)
            {
                ActualApiKey = apiKey;
            }
        }
        public LoggedUser UserData()
        {
            var loggedUser = new LoggedUser();


            return loggedUser;
        }
    }
}
