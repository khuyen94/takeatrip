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
    public interface ITourService : IService<Tour>
    {
        TourPage GetTourPage(GetTourPageQuery query);

        TourPage GetTourPageByOrderBy(string orderBy);

        Tour GetTourDetail(int id);
    }

    public class TourService : Service<Tour>, ITourService
    {
        private readonly IRepositoryAsync<Tour> _tourRepository;
        private readonly IRepositoryAsync<Review> _reviewRepository;
        private readonly IRepositoryAsync<Image> _imageRepository;

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public TourService(IRepositoryAsync<Tour> tourRepository,
            IRepositoryAsync<Review> reviewRepository,
            IRepositoryAsync<Image> imageRepository,
            IUnitOfWorkAsync unitOfWorkAsync) : base(tourRepository)
        {
            _tourRepository = tourRepository;
            _reviewRepository = reviewRepository;
            _imageRepository = imageRepository;

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
            Tour[] tourQuery = null;
            if (string.IsNullOrEmpty(query.SearchText) && string.IsNullOrEmpty(query.Location) && string.IsNullOrEmpty(query.TourType))
            {
                tourQuery = _tourRepository.GetBaseQuery().ToArray();
            }
            else
            {
                tourQuery = _tourRepository
                .Queryable()
                .Where(m => m.Name.Contains(query.SearchText) || m.Location.Contains(query.Location) || m.Description.Contains(query.TourType))
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
            Tour[] tourQuery = null;
            switch (orderBy)
            {
                case "all":
                    tourQuery = _tourRepository.GetBaseQuery()
                                           .ToArray();
                    break;
                case "popular":
                    tourQuery = _tourRepository.GetBaseQuery()
                                           .OrderByDescending(m => m.Views)
                                           .ToArray();
                    break;
                case "latest":
                    tourQuery = _tourRepository.GetBaseQuery()
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
            var rateList = _reviewRepository
                .GetBaseQuery()
                .Where(m => m.TourId == id)
                .ToList();

            var count = rateList.Count();

            float rate = rateList.Sum(m => m.Rate);

            return rate > 0 ? rate / count : rate;

        }

        private string GetImageLink(int id)
        {
            return _imageRepository
                .GetBaseQuery()
                .Where(m => m.TourId == id)
                .Select(m => m.Link)
                .FirstOrDefault();

        }

        private TourPageItem[] GetTourPageModel(Tour[] model)
        {
            return model.Select(m => new TourPageItem()
            {
                Id = m.Id.ToString(),
                TourName = m.Name,
                Locations = m.Location,
                Views = m.Views,
                Rates = GetRate(m.Id).ToString(),
                ShortContent = m.ShortDes,
                Price = m.Price.ToString(),
                Img = GetImageLink(m.Id)
            }).ToArray();
        }

        public Tour GetTourDetail(int id)
        {
            Increaseview(id);
            return _tourRepository.GetBaseQuery().Where(m => m.Id == id).FirstOrDefault();
        }

        private void Increaseview(int id)
        {
            var tour = _tourRepository.GetBaseQuery()
                .Where(m => m.Id == id).FirstOrDefault();

            tour.Views = tour.Views + 1;

            _unitOfWorkAsync.SaveChanges();
        }
    }
}
