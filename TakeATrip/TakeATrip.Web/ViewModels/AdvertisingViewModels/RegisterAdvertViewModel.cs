using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TakeATrip.Web.ViewModels.AdvertisingViewModels
{
    public class RegisterAdvertViewModel
    {
        [Display(Name = "Package")]
        [Required]
        public Package? Package { get; set; }

        [Required]
        [Display(Name = "Tour")]
        public int Tour { get; set; }
        public SelectListItem[] TourItem { get; set; }

        [Required]
        public string StartDate { get; set; }
    }

    public enum Package
    {
        Standard,
        Advance,
        Business,
        Premium
    }
}
