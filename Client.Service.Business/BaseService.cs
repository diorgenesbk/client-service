using Client.Domain.Entities;
using Client.Domain.Interfaces;
using Client.Infrastructure.Context;
using Client.Infrastructure.Repository;
using System;
using System.Collections.Generic;

namespace Client.Service.Business
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public BaseRepository<T> Repository;

        public BaseService(ClientContext context)
        {
            this.Repository = new BaseRepository<T>(context);
        }

        public BaseService(TokenContext context)
        {
            this.Repository = new BaseRepository<T>(context);
        }

        public T Insert<V>(T obj)
        {
            this.Repository.Insert(obj);
            return obj;
        }

        public T Update<V>(T obj)
        {
            this.Repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("Não foi possível deletar o registro de id: {id}");

            this.Repository.Remove(id);
        }

        public IList<T> Get() => this.Repository.SelectAll();

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException($"Não foi possível encontrar o registro de id: {id}");

            return this.Repository.Select(id);
        }
    }
}
