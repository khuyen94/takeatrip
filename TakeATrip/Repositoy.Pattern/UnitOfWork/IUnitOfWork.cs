using Repositoy.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Repositoy.Pattern.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        void BeginTransaction();
        bool Commit();
        void Rollback();
    }
}
