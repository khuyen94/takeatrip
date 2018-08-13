using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Text;
using TakeATrip.Entities.Core;

namespace TakeATrip.Services.Core
{
    public interface IOrderService : IService<Order>
    {
        
    }

    internal class OrderService : Service<Order>, IOrderService
    {
        private readonly IRepositoryAsync<Order> _repository;

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        public OrderService(IRepositoryAsync<Order> repository, IUnitOfWorkAsync unitOfWorkAsync) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }
    }
}
