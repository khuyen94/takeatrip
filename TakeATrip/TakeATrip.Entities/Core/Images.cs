using System;
using System.Collections.Generic;

namespace TakeATrip.Entities.Core
{
    public partial class Images
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public string Link { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
