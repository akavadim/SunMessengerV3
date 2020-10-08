using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Domain.Core.Chats.ValueObjects
{
    public class UserHistory
    {
        internal UserHistory(Guid userId)
        {
            DateFrom = DateTime.UtcNow;
            UserId = userId;
        }

        public Guid UserId { get; set; }

        public DateTime DateFrom { get; private set; }
        public DateTime? DateTo { get; private set; }

        internal void Close()
        {
            if (DateTo != null)
                throw new Exception("Пользователь уже вышел из чата");
            DateTo = DateTime.UtcNow;
        }
    }
}
