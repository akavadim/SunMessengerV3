using SunMessengerV3.Domain.Core.Chats.ValueObjects;
using SunMessengerV3.Infrastructure.Core.Chats.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Chats.Objects
{
    public class GroupChat:Chat
    {
        private List<UserLink> users=new List<UserLink>();
        private List<UserHistory> usersHistory =new List<UserHistory>();

        //Ef
        protected GroupChat() { }
        public GroupChat(string chatName, Guid creatorId)
        {
            this.CreatorId = creatorId;
            this.Name = chatName;
        }

        public Guid CreatorId { get; }
        public string Name { get; }
        public override IEnumerable<UserLink> Users => users;
        public IEnumerable<UserHistory> UsersHistory => usersHistory;

        public void AddUser(Guid initiatorId, Guid userId)
        {
            if (!users.Any(u => u.UserId == initiatorId))
                throw new ArgumentException("Вы должные состоять в чате", nameof(initiatorId));
            if (users.Any(u => u.UserId == userId))
                throw new ArgumentException("Пользователь уже состоит в чате", nameof(userId));
            users.Add(new UserLink(userId));
            usersHistory.Add(new UserHistory(userId));
        }

        public void RemoveUser(Guid userId)
        {
            if (!users.Any(u => u.UserId == userId))
                throw new ArgumentException("Пользователь с таким id не состоит в чате");
            users.Remove(users.First(u => u.UserId == userId));
            usersHistory.First(uh => uh.UserId == userId).Close();
        }
    }
}
