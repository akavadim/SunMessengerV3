using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Core.Chats.Repositories;
using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Services.Chats.Abstractions
{
    interface IChatService
    {
        void CreateChat(Chat chat);
        Chat FindById(Guid chatId);

        void SaveChanges();
    }
}
