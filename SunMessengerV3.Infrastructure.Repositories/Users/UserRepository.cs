using SunMessengerV3.Infrastructure.Core.Users.Objects;
using SunMessengerV3.Infrastructure.Core.Users.Repository;
using SunMessengerV3.InfrastructureChats.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly MessengerContext db;

        public UserRepository(MessengerContext messengerContext)
        {
            db = messengerContext;
        }

        public void Add(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(Guid id)
        {
            var item = db.Users.Find(id);
            if (item != null)
                db.Users.Remove(item);
        }

        public User FindById(Guid id)
        {
            return db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.AsEnumerable();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
