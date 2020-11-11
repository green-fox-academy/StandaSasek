using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ChatA.Models.Entities;
using Newtonsoft.Json;

namespace ChatA.Services
{
    public class MessageService
    {
        private const string urlMessageApi = "https://latest-chat.herokuapp.com/api";
        private readonly HttpClient httpClient;
        private static string ActualApiKey { get; set; }

        public MessageService(IHttpClientFactory clientFactory)
        {
            httpClient = clientFactory.CreateClient();
            ActualApiKey = UserService.GetApiKey();
            httpClient.DefaultRequestHeaders.Add("apikey", ActualApiKey);
        }

        internal string GenericRequest(string requestData, string urlString)
        {
            var httpContent = new StringContent(requestData, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync((urlMessageApi + urlString), httpContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }

        internal Message PostMessage(/*int channelId,*/ string content)
        {
            int? channelId = null;
            string channelSecret = null;
            var requestData = JsonConvert.SerializeObject(new { channelId, channelSecret, content });
            var urlString = "/message";
            var data = GenericRequest(requestData, urlString);
            var messageResponse = JsonConvert.DeserializeObject<Message>(data);
            messageResponse.Content = content;

            return messageResponse;
        }

        internal List<Message> GetMessagesByChannel(/*int channelId,*/ int count)
        {
            var channelMessages = new Channel();
            var requestData = JsonConvert.SerializeObject(new { channelId = channelMessages.ChannelId, channelSecret = channelMessages.ChannelSecret, count });
            var urlString = "/channel/get-messages";
            var data = GenericRequest(requestData, urlString);
            var channelResponse = JsonConvert.DeserializeObject<Channel>(data);
            var messages = channelResponse.Messages;

            return messages;
        }

        /*internal string RegisterUser(string login, string password)
        {
            var requestData = JsonConvert.SerializeObject(new { login = login, password = password });
            var urlString = "/register";
            var data = GenericRequest(requestData, urlString);
            var user = JsonConvert.DeserializeObject<User>(data);

            return String.IsNullOrEmpty(user.Login) ? "User registration status: False" : "User registration status: OK";
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
            var response = httpClient.GetAsync(urlMessageApi + "/user").Result;
            var data = response.Content.ReadAsStringAsync().Result;
            var loggedUser = JsonConvert.DeserializeObject<LoggedUser>(data);
            loggedUser.ApiKey = ActualApiKey;
            loggedUser.Login = new User().Login;

            return loggedUser;
        }*/
    }
}