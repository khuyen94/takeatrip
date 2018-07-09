using Repositoy.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repositoy.Pattern.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class;
    }
}
