using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TakeATrip.Services.Core;
using TakeATrip.Services.Models.TourModels;
using TakeATrip.Web.ViewModels.TourViewModels;

namespace TakeATrip.Web.Controllers
{
    public class TourController : Controller
    {
        private ITourService _tourService;
        private IReviewService _reviewService;
        private IConfiguration _configuration;
        private IMapper _mapper;
        public TourController(ITourService tourService, IReviewService reviewService, IConfiguration configuration, IMapper mapper)
        {
            _tourService = tourService;
            _reviewService = reviewService;
            _configuration = configuration;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var tourPageModel = new TourPage
            {
                TourTypeItem = _tourService.GetTourType()
            };

            return View(tourPageModel);
        }
        public PartialViewResult GetTourList(int pageIndex, int pageSize, string searchText, string location, string tourType, string orderBy, string viewType)
        {
            var query = new GetTourPageQuery
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                SearchText = searchText,
                Location = location,
                TourType = tourType,
                OrderBy = orderBy
            };

            var tourPage = _tourService.GetTourPage(query);
            if (string.IsNullOrEmpty(viewType))
            {
                tourPage.ViewType = "";
                return PartialView("_TourPagePartial", GetPath(tourPage));
            }
            else
            {
                tourPage.ViewType = "true";
                return PartialView("_TourListPagePartial", GetPath(tourPage));
            }
        }

        public PartialViewResult GetTourListByOrderBy(string orderBy)
        {
            if (!string.IsNullOrEmpty(orderBy))
            {
                var tourPage = _tourService.GetTourPageByOrderBy(orderBy);

                return PartialView("_TourPagePartial", GetPath(tourPage));
            }
            return PartialView("_TourPagePartial");
        }

        public PartialViewResult GetTourIsotopeListByOrderBy(string orderBy)
        {
            if (!string.IsNullOrEmpty(orderBy))
            {
                var tourPage = _tourService.GetTourPageByOrderBy(orderBy);

                return PartialView("_TourIsotopePagePartial", tourPage);
            }
            return PartialView("_TourIsotopePagePartial");
        }

        public IActionResult Detail(string id)
        {
            var tourdetail = _tourService.GetTourDetail(int.Parse(id));
            var tourDetailViewModel = _mapper.Map<TourDetailViewModel>(tourdetail);
            return View(tourDetailViewModel);
        }

        public PartialViewResult GetReview(string id)
        {
            var reviewModel = _reviewService.GetReview(id);
            return PartialView("_ReviewPagePartial", reviewModel);
        }

        public TourPage GetPath(TourPage page)
        {
            foreach (var item in page.Items)
            {
                item.Img = _configuration["ImgPath"] + "/" + item.Id + "/" + item.Img;
            }
            return page;
        }
    }
}