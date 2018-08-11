using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TakeATrip.Entities.IdentityDB;
using TakeATrip.Services.Core;
using TakeATrip.Web.ViewModels.AdvertisingViewModels;

namespace TakeATrip.Web.Controllers
{
    public class AdvertisingController : Controller
    {
        private ITourService _tourService;
        private readonly UserManager<ApplicationUser> _userManager;
        private IMapper _mapper;

        public AdvertisingController(ITourService tourService,
                             IMapper mapper,
                             UserManager<ApplicationUser> userManager)
        {
            _tourService = tourService;
            _mapper = mapper;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var user = await _userManager.GetUserAsync(User);

            var model = new RegisterAdvertViewModel
            {
                //Package = null,
                TourItem = _tourService.GetListTour(user.Email)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterAdvertViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            model.TourItem = _tourService.GetListTour(user.Email);
            if (ModelState.IsValid)
            {
                return View("PaymentTemplate");
            }

            ModelState.AddModelError("ModelError", "Please recheck your data");
            return View(model);
        }
    }
}