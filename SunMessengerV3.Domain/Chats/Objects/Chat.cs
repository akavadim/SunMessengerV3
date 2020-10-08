using SunMessengerV3.Infrastructure.Core.Chats.ValueObjects;
using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Chats.Objects
{
    public abstract class Chat
    {
        public Guid Id { get; } = new Guid();
        public abstract IEnumerable<UserLink> Users { get; }
        public DateTime Date { get; } = DateTime.UtcNow;
    }
}
