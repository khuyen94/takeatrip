using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeATrip.Web.ViewModels.TourViewModels
{
    public class TourDetailViewModel
    {
        public string Id { get; set; }
        public string TourName { get; set; }
        public int Views { get; set; }
        public string Locations { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string TourType { get; set; }
        public TourImage[] Images { get; set; }
    }

    public class TourImage
    {
        public string ImgUrl { get; set; }
    }
}
