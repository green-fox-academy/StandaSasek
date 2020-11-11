using System.Collections.Generic;
using ChatA.Models.Entities;

namespace ChatA.Models.ViewModels
{
    public class IndexViewModel
    {
        public LoggedUser MyLoggedUser { get; set; }
        public Message MyMessage { get; set; }
        public List<Message> MyMessages { get; set; }

        public IndexViewModel(LoggedUser myLoggedUser)
        {
            MyLoggedUser = myLoggedUser;
        }

        public IndexViewModel()
        {
        }

        public IndexViewModel(LoggedUser myLoggedUser, Message myMessage, List<Message> myMessages) : this(myLoggedUser)
        {
            MyMessage = myMessage;
            MyMessages = myMessages;
        }

        public IndexViewModel(LoggedUser myLoggedUser, List<Message> myMessages) : this(myLoggedUser)
        {
            MyMessages = myMessages;
        }
    }
}