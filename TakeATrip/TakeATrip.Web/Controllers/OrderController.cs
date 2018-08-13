using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TakeATrip.Entities.IdentityDB;
using TakeATrip.Services.Core;

namespace TakeATrip.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<ApplicationUser> _userManager;
        public OrderController(
            UserManager<ApplicationUser> userManager, 
            ICartService cartService)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        public IActionResult YourCart()
        {
            return View();
        }

        public int GetTotalItem()
        {
            string userId = _userManager.GetUserId(User);
            return _cartService.GetTotalItem(userId);
        }
    }
}