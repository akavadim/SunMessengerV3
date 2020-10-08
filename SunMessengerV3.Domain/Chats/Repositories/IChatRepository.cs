using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Chats.Repositories
{
    public interface IChatRepository:IWriteRepository<Chat>
    {
        Chat FindWithActiveUser(Guid chatId, Guid userId);
        Chat FindWithNotActiveUser(Guid chatId, Guid userId);
        Chat FindWithAnyUser(Guid chatId, Guid userId);
        IEnumerable<Chat> GetWithActiveUser(Guid userId);
        IEnumerable<Chat> GetWithActiveUser(Guid userId1, Guid userId2);
        IEnumerable<Chat> GetWithNotActiveUser(Guid userId);
        IEnumerable<Chat> GetWithAnyUser(Guid userId);
    }
}
