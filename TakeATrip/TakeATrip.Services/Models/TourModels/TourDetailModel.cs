using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TakeATrip.Services.Models.TourModels
{
    public class TourDetailModel
    {
        public int Id { get; set; }
        public string TourName { get; set; }
        public int Views { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Price { get; set; }
        public int TourType { get; set; }
        public string Plan { get; set; }
        public string Included { get; set; }
        public string Excluded { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }
        public IFormFile ThumbNail { get; set; }
        public string ThumbNailLink { get; set; }
    }
}
