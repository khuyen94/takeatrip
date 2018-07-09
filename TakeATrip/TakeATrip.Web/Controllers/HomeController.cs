using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repositoy.Pattern.UnitOfWork;
using TakeATrip.Entities.Core;
using TakeATrip.Web.Models;

namespace TakeATrip.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWorkAsync unitOfWorkAsync;

        public HomeController(IUnitOfWorkAsync unitOfWorkAsync)
        {
            this.unitOfWorkAsync = unitOfWorkAsync;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error(string statusCode)
        {
            if (statusCode == "500" || statusCode == "404")
            {
                return View($"~/Views/Home/Error/404.cshtml");
            }
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
