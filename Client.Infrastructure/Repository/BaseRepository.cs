using Client.Domain.Entities;
using Client.Domain.Interfaces;
using Client.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Client.Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public DbContext Context;

        public BaseRepository(ClientContext context)
        {
            this.Context = context;
        }

        public BaseRepository(TokenContext context)
        {
            this.Context = context;
        }

        public void Insert(T obj)
        {
            this.Context.Set<T>().Add(obj);
            this.Context.SaveChanges();
        }

        public void Update(T obj)
        {
            this.Context.Entry(obj).State = EntityState.Modified;
            this.Context.SaveChanges();
        }

        public void Remove(int id)
        {
            this.Context.Set<T>().Remove(Select(id));
            this.Context.SaveChanges();
        }

        public IList<T> SelectAll()
        {
            return this.Context.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return this.Context.Set<T>().Find(id);
        }
    }
}
