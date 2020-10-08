using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Interfaces.Repositories
{
    public interface IWriteRepository<T>:IReadRepository<T>
    {
        void Add(T item);
        void Delete(Guid id);
        void Save();
    }
}
