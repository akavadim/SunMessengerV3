using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Messages.ValueObjects
{
    public class ChatLink
    {
        internal ChatLink(Guid chatId)
        {
            this.ChatId = chatId;
        }

        public Guid ChatId { get; }
    }
}
