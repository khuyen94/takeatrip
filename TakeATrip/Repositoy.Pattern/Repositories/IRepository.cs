using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repositoy.Pattern.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Find(params object[] keyValues);
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void InsertGraphRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        IQueryable<TEntity> Queryable();
        IRepository<T> GetRepository<T>() where T : class;
    }
}
