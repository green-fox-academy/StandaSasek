using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatA.Models.Entities
{
    public class Message
    {
        public int ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public LoggedUser Author { get; set; }

        public Message()
        {
        }
        
    }
}
