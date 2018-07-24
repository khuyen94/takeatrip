using Microsoft.AspNetCore.Http;
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
        public string Location { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 50)]
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
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Tour Type")]
        public int TourType { get; set; }
        public SelectListItem[] TourTypeItem { get; set; }

        [Display(Name = "Note")]
        public string Notes { get; set; }

        [Required]
        [Display(Name = "Included")]
        public string Included { get; set; }

        [Required]
        [Display(Name = "Excluded")]
        public string Excluded { get; set; }

        [Display(Name = "Duration")]
        [Range(1, 20, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Duration { get; set; }

        [Display(Name = "Duration Unit")]
        public string DurationUnit { get; set; }

        [Display(Name = "Thumb Nail")]
        public IFormFile ThumbNail { get; set; }

    }
}
