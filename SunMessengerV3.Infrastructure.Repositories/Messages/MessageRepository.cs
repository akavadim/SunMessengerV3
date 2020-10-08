using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using SunMessengerV3.Infrastructure.Core.Messages.Repositories;
using SunMessengerV3.InfrastructureChats.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Repositories.Messages
{
    public class MessageRepository : IMessageRepository
    {
        private readonly MessengerContext db;

        public MessageRepository(MessengerContext messengerContext)
        {
            this.db = messengerContext;
        }

        public void Add(Message item)
        {
            db.Messages.Add(item);
        }

        public void Delete(Guid id)
        {
            var message = db.Messages.Find(id);
            if (message != null)
                db.Messages.Remove(message);
        }

        public Message FindById(Guid id)
        {
            return db.Messages.Find(id);
        }

        public IEnumerable<Message> GetAll()
        {
            return db.Messages.AsEnumerable();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
