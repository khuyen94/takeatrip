using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TakeATrip.Web.ViewModels.TourViewModels
{
    public class CreateTourViewModel
    {
        [Required]
        [StringLength(250, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 20)]
        [DataType(DataType.Text)]
        [Display(Name = "Tour Name")]
        public string TourName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 20)]
        [DataType(DataType.Text)]
        [Display(Name = "Location")]
        public string Locations { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 100)]
        [DataType(DataType.Text)]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }
        [Required]
        [MinLength(100, ErrorMessage = "The {0} cannot be longer than 100 characters.")]
        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [MinLength(100, ErrorMessage = "The {0} cannot be longer than 100 characters.")]
        [DataType(DataType.Text)]
        [Display(Name = "Plan")]
        public string Plan { get; set; }
        [Required]
        [MinLength(18, ErrorMessage = "The {0} cannot be longer than 18 characters.")]
        [Display(Name = "Price")]
        public string Price { get; set; }
        [Required]
        [Display(Name = "Tour Type")]
        public string TourType { get; set; }
        public SelectListItem[] TourTypeItem { get; set; }
    }
}
