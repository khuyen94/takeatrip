using Microsoft.AspNetCore.Mvc.Rendering;
using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TakeATrip.Entities.Core;
using TakeATrip.Repositories.Repositories;
using TakeATrip.Services.Models.TourModels;

namespace TakeATrip.Services.Core
{
    public interface ITourService : IService<Tours>
    {
        TourPage GetTourPage(GetTourPageQuery query);

        TourPage GetTourPageByOrderBy(string orderBy);

        Tours GetTourDetail(int id);

        SelectListItem[] GetTourType();

        int CreateTour(CreatTourModel model);
    }
    public class TourService : Service<Tours>, ITourService
    {
        private readonly IRepositoryAsync<Tours> _repository;

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;
        public TourService(IRepositoryAsync<Tours> repository, IUnitOfWorkAsync unitOfWorkAsync) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
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
                Img = GetImageLink(m.Id),
                TourType = GetTourType(m.Id)
            }).ToArray();
        }

        public Tours GetTourDetail(int id)
        {
            Increaseview(id);
            return _repository.GetBaseQuery().Where(m => m.Id == id).FirstOrDefault();
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
                .Select(m=>new SelectListItem {
                    Text = m.Name,
                    Value = m.Id.ToString()
                })
                .ToArray();
        }

        public string  GetTourType(int id)
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
                    Location = model.Locations,
                    Status = 1,
                    Views = 0,
                    TypeId = int.Parse(model.TourType),
                    CreatedDate = DateTime.Now,
                    CreatedBy = "hungvd"
                };

                _repository.Insert(tour);
                var reult = _unitOfWorkAsync.SaveChanges();
                if(reult > 0)
                {
                    return 1;
                }
                return 0;
            }
             catch(Exception ex)
            {
                return -1;
            }
        }
    }
}
