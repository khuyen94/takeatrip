using System;
using System.Collections.Generic;
using System.Text;

namespace TakeATrip.Services.Models.ReviewModels
{
    public class ReviewModel
    {
        public float RateAvg { get; set; }
        public int TotalReview { get; set; }
        public Rate[] Rate { get; set; }
        public UserReview[] Review { get; set; }
    }
    public class UserReview
    {
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public int Rates { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Comment { get; set; }
    }

    public class Rate
    {
        public int star { get; set; }

        public float Percent { get; set; }
    }
}
