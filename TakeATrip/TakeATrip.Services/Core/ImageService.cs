using Microsoft.AspNetCore.Http;
using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeATrip.Entities.Core;
using TakeATrip.Services.Models.ImageModels;

namespace TakeATrip.Services.Core
{
    public interface IImagesServices : IService<Images>
    {
        Task<int> UploadImage(int tourId, IFormFile thumbNail, string createdBy);
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

        public async Task<int> UploadImage(int tourId, IFormFile thumbNail, string createdBy)
        {
            string path = null;
            try
            {
                if (thumbNail != null && thumbNail.Length > 0)
                {
                    path = Path.Combine(
                       Directory.GetCurrentDirectory(), "wwwroot/img/tours/" + tourId, thumbNail.FileName);

                    var directory = new DirectoryInfo("wwwroot/img/tours/" + tourId);

                    if (!directory.Exists)
                    {
                        directory.Create();
                    }


                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await thumbNail.CopyToAsync(stream);
                    }

                    var image = _repository.GetRepository<Images>().Queryable().Where(m => m.TourId == tourId).FirstOrDefault();
                    if (image == null)
                    {
                        image = new Images
                        {
                            TourId = tourId,
                            Link = thumbNail.FileName,
                            Status = 1,
                            CreatedBy = createdBy,
                            CreatedDate = DateTime.Now
                        };
                        _repository.GetRepository<Images>().Insert(image);
                    }
                    else
                    {
                        image.Link = thumbNail.FileName;
                        image.CreatedBy = createdBy;
                        image.CreatedDate = DateTime.Now;
                        _repository.GetRepository<Images>().Update(image);
                    }

                    _unitOfWorkAsync.SaveChanges();
                    return 1;
                }
                return -1;
            }

            catch (Exception ex)
            {
                var directory = new DirectoryInfo(path);

                if (directory.Exists)
                {
                    directory.Delete();
                }
                return -2;
            }
        }
    }
}
