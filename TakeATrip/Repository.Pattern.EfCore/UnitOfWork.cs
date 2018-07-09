using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repository.Pattern.EfCore
{
    public class UnitOfWork : IUnitOfWorkAsync
    {
        #region Private Fields

        private DbContext _dataContext;
        private bool _disposed;
        private IDbContextTransaction _transaction;
        private Dictionary<string, dynamic> _repositories;

        #endregion Private Fields

        #region Constuctor/Dispose

        public UnitOfWork(DbContext dataContext)
        {
            _dataContext = dataContext;
            _repositories = new Dictionary<string, dynamic>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // free other managed objects that implement
                // IDisposable only

                if (_dataContext != null)
                {
                    _dataContext.Dispose();
                    _dataContext = null;
                }
            }

            // release any unmanaged objects
            // set the object references to null

            _disposed = true;
        }

        #endregion Constuctor/Dispose

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return RepositoryAsync<TEntity>();
        }

        public Task<int> SaveChangesAsync()
        {
            return _dataContext.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _dataContext.SaveChangesAsync(cancellationToken);
        }

        public IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<string, dynamic>();
            }

            var type = typeof(TEntity).Name;

            if (_repositories.ContainsKey(type))
            {
                return (IRepositoryAsync<TEntity>)_repositories[type];
            }

            var repositoryType = typeof(Repository<>);

            _repositories.Add(type, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _dataContext, this));

            return _repositories[type];
        }

        #region Unit of Work Transactions

        public void BeginTransaction()
        {            
            if (_dataContext.Database.GetDbConnection().State != ConnectionState.Open)
            {
                _dataContext.Database.OpenConnection();
            }

            _transaction = _dataContext.Database.BeginTransaction();
        }

        public bool Commit()
        {
            _transaction.Commit();
            return true;
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        #endregion
    }
}
