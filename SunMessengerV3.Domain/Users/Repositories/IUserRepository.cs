using SunMessengerV3.Infrastructure.Core.Users.Objects;
using SunMessengerV3.Infrastructure.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Core.Users.Repository
{
     public interface IUserRepository:IWriteRepository<User>
    {

    }
}
