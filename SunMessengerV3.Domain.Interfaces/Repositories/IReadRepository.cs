using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Interfaces.Repositories
{
    public interface IReadRepository<T>
    {
        T FindById(Guid id);
        IEnumerable<T> GetAll();
    }
}
