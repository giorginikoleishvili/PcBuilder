using Microsoft.EntityFrameworkCore;
using PcBuilder.Data.Common.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PcBuilder.Data.Common.Implementation
{
    public abstract class Repository<C, T> : IRepository<T> where T : class where C : DbContext, new()
    {
        protected C Context;
        protected readonly DbSet<T> DbSet;
        internal Repository(C entity)
        {
            Context = entity;
            DbSet = entity.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = Context.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = Context.Set<T>().Where(predicate);
            return query;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

    }
}
