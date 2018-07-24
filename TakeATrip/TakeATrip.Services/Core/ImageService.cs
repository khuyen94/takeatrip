using Microsoft.AspNetCore.Http;
using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TakeATrip.Entities.Core;
using TakeATrip.Services.Models.ImageModels;

namespace TakeATrip.Services.Core
{
    public interface IImagesServices : IService<Images>
    {
    }

    public class ImagesService : Service<Images>, IImagesServices
    {
        private readonly IRepositoryAsync<Images> _repository;

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public ImagesService(IRepositoryAsync<Images> repository, IUnitOfWorkAsync unitOfWorkAsync) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }
    }
}
