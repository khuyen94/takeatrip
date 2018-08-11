using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using TakeATrip.Services.Core;
using TakeATrip.Services.Models.TourModels;
using TakeATrip.Web.ViewModels.TourViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using TakeATrip.Entities.IdentityDB;

namespace TakeATrip.Web.Controllers
{
    public class TourController : Controller
    {
        private ITourService _tourService;
        private IReviewService _reviewService;
        private IConfiguration _configuration;
        private IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public TourController(ITourService tourService,
                              IReviewService reviewService,
                              IConfiguration configuration,
                              IMapper mapper,
                              UserManager<ApplicationUser> userManager)
        {
            _tourService = tourService;
            _reviewService = reviewService;
            _configuration = configuration;
            _mapper = mapper;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var tourPageModel = new TourPage
            {
                TourTypeItem = _tourService.GetTourType()
            };

            return View(tourPageModel);
        }

        public PartialViewResult GetTourList(int pageIndex, int pageSize, string searchText, string location, string tourType)
        {
            var query = new GetTourPageQuery
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                SearchText = searchText,
                Location = location,
                TourType = tourType,
            };

            var tourPage = _tourService.GetTourPage(query);
            foreach (var item in tourPage.Items)
            {
                item.ThumbNail = GetPath(item.Id, item.ThumbNail);
            }
            return PartialView("_TourPagePartial", tourPage);
        }

        public PartialViewResult GetTourListByOrderBy(string orderBy)
        {
            if (!string.IsNullOrEmpty(orderBy))
            {
                var tourPage = _tourService.GetTourPageByOrderBy(orderBy);

                foreach(var item in tourPage.Items)
                {
                    item.ThumbNail = GetPath(item.Id, item.ThumbNail);
                }
                return PartialView("_TourPagePartial", tourPage);
            }
            return PartialView("_TourPagePartial");
        }

        public IActionResult Detail(string id)
        {
            var tourdetail = _tourService.GetTourDetail(int.Parse(id),null);
            var tourDetailViewModel = _mapper.Map<TourDetailViewModel>(tourdetail);
            return View(tourDetailViewModel);
        }

        public PartialViewResult GetReview(string id)
        {
            var reviewModel = _reviewService.GetReview(id);
            return PartialView("_ReviewPagePartial", reviewModel);
        }

        public string GetPath(string id, string fileName)
        {

            return _configuration["ImgPath"] + "/" + id + "/" + fileName;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            var tourPageModel = new CreateTourViewModel
            {
                TourTypeItem = _tourService.GetTourType()
            };

            return View(tourPageModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTourViewModel model)
        {
            model.TourTypeItem = _tourService.GetTourType();
            if (ModelState.IsValid)
            {
                var tourModel = _mapper.Map<CreatTourModel>(model);
                var user = await _userManager.GetUserAsync(User);
                tourModel.CreatedBy = user.UserName;
                var result = _tourService.CreateTour(tourModel);
                switch (await result)
                {
                    case 1:
                        return Redirect("/Tour");
                    case -1:
                        ModelState.AddModelError("ModelError", "Cannot save your thumbnail. Please contact to admin");
                        return View(model);
                    case -2:
                        ModelState.AddModelError("ModelError", "Creat tour failed. Please recheck your image");
                        return View(model);
                    default:
                        return Redirect("/Tour/Index");
                }

            }
            ModelState.AddModelError("ModelError", "Please recheck your data");
            return View(model);
        }

        [Authorize]
        public IActionResult TourManagement()
        {
            var tourPageModel = new TourPage
            {
                TourTypeItem = _tourService.GetTourType()
            };

            return View(tourPageModel);
        }

        [Authorize]
        public async Task<PartialViewResult> GetTourManagementList(int pageIndex, int pageSize, string searchText, string location, string tourType)
        {

            var user = await _userManager.GetUserAsync(User);
            var query = new GetTourPageQuery
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                SearchText = searchText,
                Location = location,
                TourType = tourType,
                CreatedBy = user.UserName
            };

            var tourPage = _tourService.GetTourPage(query);
            foreach (var item in tourPage.Items)
            {
                item.ThumbNail = GetPath(item.Id, item.ThumbNail);
            }
            return PartialView("_TourManagementPartial", tourPage);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var user = await _userManager.GetUserAsync(User);
            var tourdetail = _tourService.GetTourDetail(int.Parse(id), user.Email);

            if(tourdetail == null)
            {
                return Redirect("/Tour");
            }

            var updateTourViewModel = _mapper.Map<UpdateTourViewModel>(tourdetail);
            updateTourViewModel.TourTypeItem = _tourService.GetTourType();
            updateTourViewModel.ThumbNailLink = GetPath(updateTourViewModel.Id, updateTourViewModel.ThumbNailLink);
            return View(updateTourViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(UpdateTourViewModel model)
        {
            model.TourTypeItem = _tourService.GetTourType();
            if (ModelState.IsValid)
            {
                var updateTourModel = _mapper.Map<UpdateTourModel>(model);
                var user = await _userManager.GetUserAsync(User);
                updateTourModel.UpdatedBy = user.UserName;
                var result = _tourService.UpdateTour(updateTourModel);

                switch (await result)
                {
                    case 1:
                        return Redirect("/Tour/TourManagement");
                    case -1:
                        ModelState.AddModelError("ModelError", "Cannot save your thumbnail. Please contact to admin");
                        return View(model);
                    case -2:
                        ModelState.AddModelError("ModelError", "Create tour failed. Please recheck your image");
                        return View(model);
                    default:
                        return Redirect("/Tour/Index");
                }

            }

            ModelState.AddModelError("ModelError", "Please recheck your data");
            return View(model);
        }
    }
}