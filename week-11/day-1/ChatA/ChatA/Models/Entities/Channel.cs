using System.Collections.Generic;

namespace ChatA.Models.Entities
{
    public class Channel
    {
        public int? ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public string Admin { get; set; }
        public List<Message> Messages { get; set; }

        public Channel()
        {
        }

        public Channel(int channelId, string channelSecret, string name, string description, string iconUrl, string admin, List<Message> messages)
        {
            ChannelId = channelId;
            ChannelSecret = channelSecret;
            Name = name;
            Description = description;
            IconUrl = iconUrl;
            Admin = admin;
            Messages = messages;
        }
    }
}