using Microsoft.EntityFrameworkCore;
using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Core.Chats.Repositories;
using SunMessengerV3.InfrastructureChats.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Repositories.Chats
{
    public class ChatRepository : IChatRepository
    {
        private readonly MessengerContext db;

        public ChatRepository(MessengerContext messengerContext)
        {
            this.db = messengerContext;
        }

        public void Add(Chat item)
        {
            db.Chats.Add(item);
        }

        public void Delete(Guid id)
        {
            var chat = db.Chats.Find(id);
            if (chat != null)
                db.Chats.Remove(chat);
        }

        public Chat FindById(Guid id)
        {
            return db.Chats.Include(c => c.Users).FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Chat> GetAll()
        {
            return db.Chats.Include(c => c.Users).AsEnumerable();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
