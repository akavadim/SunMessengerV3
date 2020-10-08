using SunMessengerV3.Infrastructure.Core.Users.Objects;
using SunMessengerV3.Infrastructure.Core.Users.Repository;
using SunMessengerV3.Infrastructure.Services.Users.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunMessengerV3.Infrastructure.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Create(User user)
        {
            if (userRepository.GetAll().Any(u => u.Login == user.Login))
                throw new ArgumentException("Пользователь с таким логином уже существует", nameof(user));
            userRepository.Add(user);
        }

        public User Find(Guid userId)
        {
            return userRepository.FindById(userId);
        }

        public void SaveChanger()
        {
            userRepository.Save();

        }
    }
}
