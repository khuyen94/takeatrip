using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Text;
using TakeATrip.Entities.Core;
using TakeATrip.Repositories.Repositories;

namespace TakeATrip.Services.Core
{
    public interface ICartService : IService<Cart>
    {
        /// <summary>
        /// Get total item in cart of user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        int GetTotalItem(string userId);
    }

    public class CartService : Service<Cart>, ICartService
    {
        private readonly IRepositoryAsync<Cart> _repository;

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        public CartService(IRepositoryAsync<Cart> repository,
            IUnitOfWorkAsync unitOfWorkAsync)
            : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        public int GetTotalItem(string userId)
        {
            return _repository.GetTotalItem(userId);
        }
    }
}
