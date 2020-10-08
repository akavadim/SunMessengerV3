using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Core.Chats.Repositories;
using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using SunMessengerV3.Infrastructure.Core.Messages.Repositories;
using SunMessengerV3.Infrastructure.Services.Chats.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Services.Chats
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository chatRepository;

        public ChatService(IChatRepository chatRepository)
        {
            this.chatRepository = chatRepository;
        }

        public void CreateChat(Chat chat)
        {
            if (chat is DirectChat)
            {
                var chats = chatRepository.GetWithActiveUser(chat.Users.First().UserId, chat.Users.Last().UserId);
                if (chats.Any(ch => ch is DirectChat))
                    throw new ArgumentException("Между данными пользователями уже есть чат");
            }
            chatRepository.Add(chat);
        }

        public Chat FindById(Guid chatId)
        {
            return chatRepository.FindById(chatId);
        }

        public Chat FindWithAnyUser(Guid chatId, Guid userId)
        {
            Chat chat = chatRepository.FindWithAnyUser(chatId, userId);
            return chat;
        }

        public Chat FindDirectChatWithUsers(Guid userId1, Guid userId2)
        {
            Chat chat = chatRepository.GetWithActiveUser(userId1, userId2)
                .Where(c => c is DirectChat)
                .FirstOrDefault();
            return chat;
        }

        public IEnumerable<Chat> GetWithAnyUser(Guid userId)
        {
            return chatRepository.GetWithAnyUser(userId);
        }

        public void SaveChanges()
        {
            chatRepository.Save();
        }
    }
}
