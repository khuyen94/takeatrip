﻿using System;
using System.Collections.Generic;

namespace TakeATrip.Entities.Core
{
    public partial class Tours
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDes { get; set; }
        public string Description { get; set; }
        public string Plan { get; set; }
        public decimal? Price { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public int Views { get; set; }
        public int TypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
