using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Users.Objects
{
    public class User
    {
        public User(string name, string login, string password)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Login = login;
            this.Password = password;
        }

        public Guid Id { get; }
        public string Name { get; }
        public string Login { get; }
        public string Password { get; }
    }
}
