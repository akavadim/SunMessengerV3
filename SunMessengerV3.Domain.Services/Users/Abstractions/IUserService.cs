using SunMessengerV3.Infrastructure.Core.Users.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Services.Users.Abstractions
{
    interface IUserService
    {
        void Create(User user);
        User Find(Guid userId);

        void SaveChanger();
    }
}
