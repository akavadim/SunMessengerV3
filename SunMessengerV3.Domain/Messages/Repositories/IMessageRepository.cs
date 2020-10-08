using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using SunMessengerV3.Infrastructure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Messages.Repositories
{
    public interface IMessageRepository:IWriteRepository<Message>
    {
        IEnumerable<Message> GetByChat(Guid chatId);
        IEnumerable<Message> GetByChatAndUser(Guid chatId, Guid userId);
    }
}
