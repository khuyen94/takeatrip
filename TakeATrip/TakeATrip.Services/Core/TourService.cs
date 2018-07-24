using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TakeATrip.Entities.Core;
using TakeATrip.Repositories.Repositories;
using TakeATrip.Services.Models.ImageModels;
using TakeATrip.Services.Models.TourModels;

namespace TakeATrip.Services.Core
{
    public interface ITourService : IService<Tours>
    {
        TourPage GetTourPage(GetTourPageQuery query);

        TourPage GetTourPageByOrderBy(string orderBy);

        TourDetailModel GetTourDetail(int id);

        SelectListItem[] GetTourType();

        int CreateTour(CreatTourModel model);

        int UpdateTour(UpdateTourModel model);
    }
    public class TourService : Service<Tours>, ITourService
    {
        private readonly IRepositoryAsync<Tours> _repository;

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        private readonly IImagesServices _imagesServices;

        public TourService(IRepositoryAsync<Tours> repository, IUnitOfWorkAsync unitOfWorkAsync, IImagesServices imagesServices) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
            _imagesServices = imagesServices;
        }

        public TourPage GetTourPage(GetTourPageQuery query)
        {
            var tourItem = GetTourItems(query);
            var totalRow = tourItem.Count();
            var pageItems = tourItem
                           .Skip(query.PageSize * query.PageIndex)
                           .Take(query.PageSize).ToArray();

            return new TourPage
            {
                Items = pageItems,
                TotalCount = totalRow,
                PageIndex = query.PageIndex,
                PageSize = query.PageSize,
                SearchText = query.SearchText
            };
        }

        private TourPageItem[] GetTourItems(GetTourPageQuery query)
        {
            Tours[] tourQuery = null;
            if (string.IsNullOrEmpty(query.SearchText) && string.IsNullOrEmpty(query.Location) && string.IsNullOrEmpty(query.TourType))
            {
                tourQuery = _repository.GetBaseQuery().ToArray();
            }
            else
            {
                tourQuery = _repository
                .Queryable()
                .Where(m => m.Name.Contains(query.SearchText) || m.Location.Contains(query.Location) || m.TypeId == int.Parse(query.TourType))
                .ToArray();
            }

            if (!string.IsNullOrEmpty(query.CreatedBy))
            {
                tourQuery = tourQuery.Where(m => m.CreatedBy == query.CreatedBy).ToArray();
            }
            return GetTourPageModel(tourQuery);
        }

        public TourPage GetTourPageByOrderBy(string orderBy)
        {
            var tourItem = GetTourItemsByOrderBy(orderBy);
            var totalRow = tourItem.Count();
            var pageItems = tourItem
                           .Take(6).ToArray();

            return new TourPage
            {
                Items = pageItems,
                TotalCount = totalRow,
                PageIndex = 1,
                SearchText = ""
            };
        }

        private TourPageItem[] GetTourItemsByOrderBy(string orderBy)
        {
            Tours[] tourQuery = null;
            switch (orderBy)
            {
                case "all":
                    tourQuery = _repository.GetBaseQuery()
                                           .ToArray();
                    break;
                case "popular":
                    tourQuery = _repository.GetBaseQuery()
                                           .OrderByDescending(m => m.Views)
                                           .ToArray();
                    break;
                case "latest":
                    tourQuery = _repository.GetBaseQuery()
                                           .OrderByDescending(m => m.CreatedDate)
                                           .ToArray();
                    break;
                default:
                    //do a different thing
                    break;
            }
            return GetTourPageModel(tourQuery);
        }

        private float GetRate(int id)
        {
            var rateList = _repository
                .GetRepository<Reviews>()
                .GetBaseQuery()
                .Where(m => m.TourId == id)
                .ToList();

            var count = rateList.Count();

            float rate = rateList.Sum(m => m.Rate);

            return rate > 0 ? rate / count : rate;

        }

        private int GetTotalReviews(int id)
        {
            return _repository.GetRepository<Reviews>().GetBaseQuery().Where(m => m.TourId == id).Count();
        }

        private string GetImageLink(int id)
        {
            return _repository
                .GetRepository<Images>()
                .GetBaseQuery()
                .Where(m => m.TourId == id)
                .Select(m => m.Link)
                .FirstOrDefault();

        }

        private TourPageItem[] GetTourPageModel(Tours[] model)
        {
            return model.Select(m => new TourPageItem()
            {
                Id = m.Id.ToString(),
                TourName = m.Name,
                Locations = m.Location,
                ToTalReViews = GetTotalReviews(m.Id),
                Rates = GetRate(m.Id),
                ShortContent = m.ShortDes,
                Price = string.Format("{0:N0}", m.Price),
                ThumbNail = GetImageLink(m.Id),
                TourType = GetTourType(m.Id),
                Duration = m.Duration + " " + m.DurationUnit
            }).ToArray();
        }

        public TourDetailModel GetTourDetail(int id)
        {
            Increaseview(id);
            return _repository.GetBaseQuery().Where(m => m.Id == id)
                .Select(m => new TourDetailModel
                {
                    Id = m.Id,
                    TourName = m.Name,
                    Description = m.Description,
                    ShortDescription = m.ShortDes,
                    Location = m.Location,
                    Plan = m.Plan,
                    Price = string.Format("{0:N0}", m.Price),
                    TourType = m.TypeId,
                    Views = m.Views,
                    Duration = m.Duration,
                    DurationUnit = m.DurationUnit,
                    Included = m.Included,
                    Excluded = m.Excluded,
                    ThumbNailLink = GetImageLink(id),
                })
                .FirstOrDefault();
        }

        private void Increaseview(int id)
        {
            var tour = _repository.GetBaseQuery().Where(m => m.Id == id).FirstOrDefault();
            tour.Views = tour.Views + 1;
            _unitOfWorkAsync.SaveChanges();
        }

        public SelectListItem[] GetTourType()
        {
            return _repository.GetRepository<TourTypes>()
                .Queryable()
                .OrderBy(m => m.Name)
                .Select(m => new SelectListItem
                {
                    Text = m.Name,
                    Value = m.Id.ToString()
                })
                .ToArray();
        }

        public string GetTourType(int id)
        {
            return _repository.GetRepository<TourTypes>()
                .Queryable()
                .Where(m => m.Id == id)
                .OrderBy(m => m.Name)
                .Select(m => m.Name)
                .FirstOrDefault();
        }

        public int CreateTour(CreatTourModel model)
        {
            try
            {
                var tour = new Tours
                {
                    Name = model.TourName,
                    ShortDes = model.ShortDescription,
                    Description = model.Description,
                    Plan = model.Plan,
                    Price = model.Price,
                    Location = model.Location,
                    Status = 1,
                    Views = 0,
                    TypeId = int.Parse(model.TourType),
                    Duration = model.Duration,
                    DurationUnit = model.DurationUnit,
                    Included = model.Included,
                    Excluded = model.Excluded,
                    CreatedDate = DateTime.Now,
                    CreatedBy = model.CreatedBy
                };
                _repository.Insert(tour);
                _unitOfWorkAsync.SaveChanges();
                var isSuccess = UploadImage(tour.Id, model.ThumbNail, model.CreatedBy);
                if (isSuccess > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int UploadImage(int tourId, IFormFile thumbNail, string createdBy)
        {
            string path = null;
            try
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
                    thumbNail.CopyToAsync(stream);
                }

                var image = _repository.GetRepository<Images>().GetBaseQuery().Where(m => m.TourId == tourId).FirstOrDefault();
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
                }
                else
                {
                    image.Link = thumbNail.FileName;
                    image.CreatedBy = createdBy;
                    image.CreatedDate = DateTime.Now;
                }

                _repository.GetRepository<Images>().Insert(image);
                _unitOfWorkAsync.SaveChanges();
                return 1;
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

        public int UpdateTour(UpdateTourModel model)
        {
            try
            {
                var tour = _repository.Queryable().Where(m => m.Id == model.Id).FirstOrDefault();
                tour.Name = model.TourName;
                tour.ShortDes = model.ShortDescription;
                tour.Description = model.Description;
                tour.Plan = model.Plan;
                tour.Price = model.Price;
                tour.Location = model.Location;
                tour.Status = 1;
                tour.Views = 0;
                tour.TypeId = int.Parse(model.TourType);
                tour.Duration = model.Duration;
                tour.DurationUnit = model.DurationUnit;
                tour.Included = model.Included;
                tour.Excluded = model.Excluded;
                tour.UpdatedDate = DateTime.Now;
                tour.UpdatedBy = model.UpdatedBy;

                _repository.Update(tour);

                _unitOfWorkAsync.SaveChanges();
                if(model.ThumbNail != null)
                {
                    var isSuccess = UploadImage(tour.Id, model.ThumbNail, model.UpdatedBy);
                    if (isSuccess > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
