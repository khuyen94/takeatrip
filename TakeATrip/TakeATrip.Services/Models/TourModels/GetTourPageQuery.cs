using System;
using System.Collections.Generic;
using System.Text;
using TakeATrip.Services.Models.BaseModels;

namespace TakeATrip.Services.Models.TourModels
{
    public class GetTourPageQuery : GetPageQuery
    {
        public string Location { get; set; }
        public string TourType { get; set; }
        public string CreatedBy { get; set; }
    }
}
