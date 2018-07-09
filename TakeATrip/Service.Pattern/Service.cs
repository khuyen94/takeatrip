using Repositoy.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Service.Pattern
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        #region Private Fields
        private readonly IRepositoryAsync<TEntity> _repository;
        #endregion Private Fields

        #region Constructor
        protected Service(IRepositoryAsync<TEntity> repository) { _repository = repository; }
        #endregion Constructor

        public virtual TEntity Find(params object[] keyValues) { return _repository.Find(keyValues); }        

        public virtual void Insert(TEntity entity) { _repository.Insert(entity); }

        public virtual void InsertRange(IEnumerable<TEntity> entities) { _repository.InsertRange(entities); }        

        public virtual void InsertGraphRange(IEnumerable<TEntity> entities) { _repository.InsertGraphRange(entities); }

        public virtual void Update(TEntity entity) { _repository.Update(entity); }

        public virtual void Delete(object id) { _repository.Delete(id); }

        public virtual void Delete(TEntity entity) { _repository.Delete(entity); }        

        public virtual async Task<TEntity> FindAsync(params object[] keyValues) { return await _repository.FindAsync(keyValues); }

        public virtual async Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues) { return await _repository.FindAsync(cancellationToken, keyValues); }

        public virtual async Task<bool> DeleteAsync(params object[] keyValues) { return await DeleteAsync(CancellationToken.None, keyValues); }
        public virtual async Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues) { return await _repository.DeleteAsync(cancellationToken, keyValues); }

        public IQueryable<TEntity> Queryable() { return _repository.Queryable(); }
    }
}
