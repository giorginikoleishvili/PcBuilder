using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PcBuilder.Data.Common.Abstraction
{
    public interface IRepository<TEntity>  where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void Delete(TEntity entity);

        void Edit(TEntity entity);

        void Save();
    }
}
