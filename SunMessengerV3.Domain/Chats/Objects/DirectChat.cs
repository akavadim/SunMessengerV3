using SunMessengerV3.Infrastructure.Core.Chats.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Chats.Objects
{
    public class DirectChat:Chat
    {
        private List<UserLink> users = new List<UserLink>();

        //Ef
        protected DirectChat() { }
        public DirectChat(Guid userId1, Guid userId2) 
        {
            AddUser(userId1);
            AddUser(userId2);
        }

        public override IEnumerable<UserLink> Users => users;

        private void AddUser(Guid userId)
        {
            if (users.Any(u => u.UserId == userId))
                throw new ArgumentException($"Чат не может содержать одинаковых пользователей", nameof(userId));
            users.Add(new UserLink(userId));
        }
    }
}
