using System;
using System.Collections.Generic;

namespace TakeATrip.Entities.Core
{
    public partial class Review
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public string Username { get; set; }
        public string Comment { get; set; }
        public byte Rate { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
