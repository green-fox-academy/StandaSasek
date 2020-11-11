using System;

namespace ChatA.Models.Entities
{
    public class Message
    {
        public int ChannelId { get; set; }
        public Channel MyChannel { get; set; }
        public string Content { get; set; }
        public DateTime? Created { get; set; }
        public LoggedUser Author { get; set; }

        public Message()
        {
        }
    }
}