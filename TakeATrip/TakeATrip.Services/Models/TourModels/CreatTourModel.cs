using System;
using System.Collections.Generic;
using System.Text;

namespace TakeATrip.Services.Models.TourModels
{
    public class CreatTourModel
    {
        public string TourName { get; set; }
        public string Locations { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Plan { get; set; }
        public Decimal Price { get; set; }
        public string TourType { get; set; }
    }
}
