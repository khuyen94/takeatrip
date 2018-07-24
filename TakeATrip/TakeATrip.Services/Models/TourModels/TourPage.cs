using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TakeATrip.Services.Models.BaseModels;

namespace TakeATrip.Services.Models.TourModels
{
    public class TourPage : Page<TourPageItem>
    {
        public string Locations { get; set; }
        public string TourType { get; set; }
        public SelectListItem[] TourTypeItem { get; set; }
    }

    public class TourPageItem
    {
        public string Id { get; set; }
        public string TourName { get; set; }
        public float Rates { get; set; }
        public int ToTalReViews { get; set; }
        public string Locations { get; set; }
        public string ShortContent { get; set; }
        public string Price { get; set; }
        public string TourType { get; set; }
        public string ThumbNail { get; set; }
        public string Duration { get; set; }
    }
}
