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
        protected Dictionary<string, dynamic> Repositories;

        #endregion Private Fields

        #region Constuctor/Dispose

        public UnitOfWork(DbContext dataContext)
        {
            _dataContext = dataContext;
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

        public Task<int> SaveChangesAsync()
        {
            return _dataContext.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _dataContext.SaveChangesAsync(cancellationToken);
        }

        public int? CommandTimeout
        {
            get => _dataContext.Database.GetCommandTimeout();
            set => _dataContext.Database.SetCommandTimeout(value);
        }

        public virtual int ExecuteSqlCommand(string sql, params object[] parameters)
        {
            return _dataContext.Database.ExecuteSqlCommand(sql, parameters);
        }

        public virtual async Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters)
        {
            return await _dataContext.Database.ExecuteSqlCommandAsync(sql, parameters);
        }

        public IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class
        {
            if (ServiceLocator.IsLocationProviderSet)
            {
                return ServiceLocator.Current.GetInstance<IRepositoryAsync<TEntity>>();
            }

            if (Repositories == null)
            {
                Repositories = new Dictionary<string, dynamic>();
            }

            var type = typeof(TEntity).Name;

            if (Repositories.ContainsKey(type))
            {
                return (IRepositoryAsync<TEntity>)Repositories[type];
            }

            var repositoryType = typeof(Repository<>);

            Repositories.Add(type, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _dataContext, this));

            return Repositories[type];
        }

        public virtual IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (ServiceLocator.IsLocationProviderSet)
            {
                return ServiceLocator.Current.GetInstance<IRepository<TEntity>>();
            }

            return RepositoryAsync<TEntity>();
        }

        public virtual async Task<int> ExecuteSqlCommandAsync(string sql, CancellationToken cancellationToken, params object[] parameters)
        {
            return await _dataContext.Database.ExecuteSqlCommandAsync(sql, cancellationToken, parameters);
        }

        #region Unit of Work Transactions

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {            
            if (_dataContext.Database.GetDbConnection().State != ConnectionState.Open)
            {
                _dataContext.Database.OpenConnection();
            }

            _transaction = _dataContext.Database.BeginTransaction(isolationLevel);
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
