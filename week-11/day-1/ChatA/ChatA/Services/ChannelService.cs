using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ChatA.Models.Entities;
using Newtonsoft.Json;

namespace ChatA.Services
{
    public class ChannelService
    {
        private const string urlChannelApi = "https://latest-chat.herokuapp.com/api/channel";
        private readonly HttpClient httpClient;
        private static string ActualApiKey { get; set; }

        public ChannelService(IHttpClientFactory clientFactory)
        {
            httpClient = clientFactory.CreateClient();
            ActualApiKey = UserService.GetApiKey();
            httpClient.DefaultRequestHeaders.Add("apikey", ActualApiKey);
        }

        internal string GenericRequest(string requestData, string urlString)
        {
            var httpContent = new StringContent(requestData, Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync((urlChannelApi + urlString), httpContent).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            return responseContent;
        }

        internal bool CreateChannel(string name, string description)
        {
            var requestData = JsonConvert.SerializeObject(new { name, description });
            var urlString = "";
            var data = GenericRequest(requestData, urlString);
            var channelResponse = JsonConvert.DeserializeObject<Channel>(data);
            

            return messageResponse;
        }

        internal List<Message> GetMessagesByChannel(/*int channelId,*/ int count)
        {
            var channelMessages = new Channel();
            var requestData = JsonConvert.SerializeObject(new { channelId = channelMessages.ChannelId, channelSecret = channelMessages.ChannelSecret, count });
            var urlString = "/get-messages";
            var data = GenericRequest(requestData, urlString);
            var channelResponse = JsonConvert.DeserializeObject<Channel>(data);
            var messages = channelResponse.Messages;

            return messages;
        }
    }
}