using Client.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Domain.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Insert<V>(T obj);

        T Update<V>(T obj);

        void Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
