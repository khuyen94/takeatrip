using Repositoy.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TakeATrip.Entities.Core;

namespace TakeATrip.Repositories.Repositories
{
    public static class ImageRepository
    {
        public static IQueryable<Image> GetBaseQuery(this IRepository<Image> repository)
        {
            return repository.Queryable()
                .Where(x => x.Status == 1);
        }
    }
}
