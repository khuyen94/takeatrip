﻿using System;
using System.Collections.Generic;

namespace TakeATrip.Entities.Core
{
    public partial class TourTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
