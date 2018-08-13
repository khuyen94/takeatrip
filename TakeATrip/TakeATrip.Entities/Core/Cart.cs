using System;
using System.Collections.Generic;

namespace TakeATrip.Entities.Core
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public string OrderId { get; set; }
        public string TourId { get; set; }
        public string UserId { get; set; }
        public int Adults { get; set; }
        public int Childrens { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
