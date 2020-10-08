using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Chats.ValueObjects
{
    public class UserLink
    {
        internal UserLink(Guid userId)
        {
            this.UserId = userId;
        }

        public Guid UserId { get; }
    }
}
