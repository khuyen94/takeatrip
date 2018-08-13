using Repositoy.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TakeATrip.Entities.Core;
namespace TakeATrip.Repositories.Repositories
{
    public static class TourRepository
    {
        public static IQueryable<Tour> GetBaseQuery(this IRepository<Tour> repository)
        {
            return repository.Queryable()
                .Where(x => x.Status == 1);
        }
    }
}
