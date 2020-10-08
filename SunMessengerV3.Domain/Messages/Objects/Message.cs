using SunMessengerV3.Infrastructure.Core.Messages.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Messages.Objects
{
    public class Message
    {
        private List<ChatLink> chats = new List<ChatLink>();

        //EF
        protected Message() { }
        public Message(string text, Guid senderId, params Guid[] chats)
        {
            Id = Guid.NewGuid();
            Text = text;
            SenderId = senderId;
            Date = DateTime.UtcNow;
            foreach (var chat in chats)
                AddChat(chat);
        }

        public Guid Id { get; }
        public Guid SenderId { get; }
        public string Text { get; }
        public DateTime Date { get; }
        public IEnumerable<ChatLink> Chats { get => chats; } 

        private void AddChat(Guid chatId)
        {
            if (chats.Any(c => c.ChatId == chatId))
                return;
            chats.Add(new ChatLink(chatId));
        }
    }
}
