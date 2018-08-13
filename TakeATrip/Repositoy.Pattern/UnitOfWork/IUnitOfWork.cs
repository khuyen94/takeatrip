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
        void BeginTransaction(IsolationLevel isolationLevel);
        bool Commit();
        void Rollback();
    }
}
