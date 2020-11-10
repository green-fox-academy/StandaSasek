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
            //httpClient.DefaultRequestHeaders.Add("apiKey", ActualApiKey);
        }

        internal string GenericRequest(string requestData, string urlString)
        {
            var httpContent = new StringContent(requestData, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync((urlApi + urlString), httpContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }
        internal string RegisterUser(string login, string password)
        {
            var requestData = JsonConvert.SerializeObject(new { login = login, password = password });
            var urlString = "/register";
            var data = GenericRequest(requestData, urlString);
            var user = JsonConvert.DeserializeObject<User>(data);

            return String.IsNullOrEmpty(user.Login) ? "User registration status: False" : "User registration status: OK";
        }
        internal string LoginUser(User user)
        {
            var requestData = JsonConvert.SerializeObject(new { login = user.Login, password = user.Password });
            var urlString = "/login";
            var data = GenericRequest(requestData, urlString);
            var loggedUser = JsonConvert.DeserializeObject<LoggedUser>(data);
            SaveUserStrings(loggedUser.ApiKey);

            return String.IsNullOrEmpty(loggedUser.ApiKey) ? "User login status: False" : "User login status: OK";
        }
        internal LoggedUser UpdateUser(string userName, string avatarUrl)
        {
            var requestData = JsonConvert.SerializeObject(new { username = userName, avatarurl = avatarUrl });
            var urlString = "/update";
            var data = GenericRequest(requestData, urlString);
            var result = JsonConvert.DeserializeObject<LoggedUser>(data);

            return result;
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
            httpClient.DefaultRequestHeaders.Add("apiKey", ActualApiKey);
            var response = httpClient.GetAsync(urlApi).Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var loggedUser = JsonConvert.DeserializeObject<LoggedUser>(data);
            loggedUser.ApiKey = ActualApiKey;
            loggedUser.Login = new User().Login;

            return loggedUser;
        }
    }
}
