using System;
using System.Collections.Generic;

namespace TakeATrip.Entities.Core
{
    public partial class Order
    {
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public string Coupon { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
    }
}
