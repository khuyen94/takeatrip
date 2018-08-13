using System;
using System.Collections.Generic;

namespace TakeATrip.Entities.Core
{
    public partial class OrderDetail
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public int TourId { get; set; }
        public int Adults { get; set; }
        public int Childrens { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public bool Deleted { get; set; }
    }
}
