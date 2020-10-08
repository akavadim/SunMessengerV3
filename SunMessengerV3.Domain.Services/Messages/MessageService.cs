using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Core.Chats.Repositories;
using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using SunMessengerV3.Infrastructure.Core.Messages.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Domain.Services.Messages
{
    public class MessageService
    {
        private readonly IChatRepository chatRepository;
        private readonly IMessageRepository messageRepository;

        public MessageService(IChatRepository chatRepository, IMessageRepository messageRepository)
        {
            this.chatRepository = chatRepository;
            this.messageRepository = messageRepository;
        }

        public Message FindMessage(Guid messageId)
        {
            return messageRepository.FindById(messageId);
        }

        public IEnumerable<Message> GetMessages(Guid chatId, Guid userId)
        {
            var chat = chatRepository.FindWithAnyUser(chatId,userId);
            if (chat == null)
                throw new ArgumentException("Пользователь не состоит в чате", nameof(chatId));
            var messages = messageRepository.GetByChatAndUser(chatId, userId);
            return messages;
        }

        public void SaveChanges()
        {
            messageRepository.Save();
        }

        public Message SendMessage(Guid senderId, string text, params Guid[] chatIds)
        {
            List<Chat> chats = new List<Chat>();
            foreach(var chatId in chatIds)
            {
                var chat = chatRepository.FindWithActiveUser(chatId, senderId)
                    ?? throw new ArgumentException($"Пользователь не состоит в чате с id {chatId}", nameof(chatIds));
                chats.Add(chat);
            }

            Message message = new Message(text, senderId, chatIds);
            messageRepository.Add(message);
            return message;
        }
    }
}
