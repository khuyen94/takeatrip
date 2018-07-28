using Repositoy.Pattern.Repositories;
using Repositoy.Pattern.UnitOfWork;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TakeATrip.Entities.Core;
using TakeATrip.Repositories.Repositories;
using TakeATrip.Services.Models.ReviewModels;

namespace TakeATrip.Services.Core
{
    public interface IReviewService : IService<Reviews>
    {
        ReviewModel GetReview(string id);
    }
    public class ReviewService : Service<Reviews>, IReviewService
    {
        private readonly IRepositoryAsync<Reviews> _repository;

        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public ReviewService(IRepositoryAsync<Reviews> repository, IUnitOfWorkAsync unitOfWorkAsync) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        public ReviewModel GetReview(string id)
        {
            int tourId = int.Parse(id);
            return new ReviewModel
            {
                RateAvg = GetRateAvg(tourId),
                TotalReview = GetTotalReview(tourId),
                Rate = GetListRate(tourId),
                Review = GetListReview(tourId)
            };
        }

        private int GetTotalReview(int id)
        {
            return _repository.Queryable()
                .Where(m => m.TourId == id)
                .Count();
        }

        private float GetRateAvg(int id)
        {
            var rateList = _repository.Queryable()
                .Where(m => m.TourId == id)
                .ToList();

            var count = rateList.Count();

            float rate = rateList.Sum(m => m.Rate);

            return rate > 0 ? rate / count : rate;
        }

        private Rate[] GetListRate(int id)
        {
            int total = GetTotalReview(id);

            var listReview = _repository.Queryable()
                .Where(m => m.TourId == id)
                .GroupBy(m => m.Rate)
                .Select(m => new
                {
                    Rate = m.Key,
                    TotalRate = m.Count()
                }).ToList();


            return listReview.Select(m => new Rate
            {
                star = m.Rate,
                Percent = (m.TotalRate / (float)total) * 100
            }).ToArray();
        }

        private Review[] GetListReview(int id)
        {
            return _repository.Queryable()
                .Where(m => m.TourId == id).Select(m => new Review
                {
                    UserName = m.Username,
                    Rates = m.Rate,
                    CreatedDate = m.CreatedDate,
                    Comment = m.Comment

                }).OrderByDescending(m => m.Rates)
                  .Take(3)
                  .ToArray();
        }
    }
}
