﻿using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ChatA.Models.Entities;
using Newtonsoft.Json;

namespace ChatA.Services
{
    public class MessageService
    {
        private const string urlMessageApi = "https://latest-chat.herokuapp.com/api/message";
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
            var urlString = "";
            var data = GenericRequest(requestData, urlString);
            var messageResponse = JsonConvert.DeserializeObject<Message>(data);
            messageResponse.Content = content;

            return messageResponse;
        }

        internal List<Message> GetMessagesByChannel(/*int channelId,*/ int count) // TODO add channel id functionality
        {
            var channelMessages = new Channel();
            var requestData = JsonConvert.SerializeObject(new { channelId = channelMessages.ChannelId, channelSecret = channelMessages.ChannelSecret, count });
            var urlString = "/channel/get-messages";
            var data = GenericRequest(requestData, urlString);
            var channelResponse = JsonConvert.DeserializeObject<Channel>(data);
            var messages = channelResponse.Messages;

            return messages;
        }
    }
}