using Repositoy.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TakeATrip.Entities.Core;

namespace TakeATrip.Repositories.Repositories
{
    public static class CartRepository
    {
        /// <summary>
        /// Get total item in cart of user
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static int GetTotalItem(this IRepository<Cart> repository, string userId)
        {
            return repository.Queryable().Count(x => x.UserId == userId);
        }
    }
}
