using Microsoft.EntityFrameworkCore;
using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repository.Pattern.EfCore
{
    public class Repository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
    {
        #region Private Fields

        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private readonly IUnitOfWorkAsync _unitOfWork;

        #endregion Private Fields

        public Repository(DbContext context, IUnitOfWorkAsync unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;

            _dbSet = context.Set<TEntity>();

        }

        public virtual TEntity Find(params object[] keyValues)
        {
            return _dbSet.Find(keyValues);
        }        

        public virtual void Insert(TEntity entity)
        {            
            _dbSet.Add(entity);            
        }

        public virtual void InsertRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Insert(entity);
            }
        }

        public virtual void InsertGraphRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public virtual void Update(TEntity entity)
        {            
            _dbSet.Update(entity);            
        }

        public virtual void Delete(object id)
        {
            var entity = _dbSet.Find(id);
            Delete(entity);
        }

        public virtual void Delete(TEntity entity)
        {            
            _dbSet.Remove(entity);            
        }

        public IQueryable<TEntity> RawQuery(string query, params object[] parameters)
        {
            return _dbSet.FromSql(query, parameters);
        }

        public IQueryable<TEntity> Queryable()
        {
            return _dbSet;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return _unitOfWork.Repository<T>();
        }

        public virtual async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }

        public virtual async Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            return await _dbSet.FindAsync(cancellationToken, keyValues);
        }

        public virtual async Task<bool> DeleteAsync(params object[] keyValues)
        {
            return await DeleteAsync(CancellationToken.None, keyValues);
        }

        public virtual async Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues)
        {
            var entity = await FindAsync(cancellationToken, keyValues);

            if (entity == null)
            {
                return false;
            }
            
            _dbSet.Remove(entity);

            return true;
        }       
    }
}
