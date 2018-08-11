using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace TakeATrip.Services.Models.ImageModels
{
    public class ImageModel
    {
        public IFormFile File { get; set; }

        public int TourId { get; set; }

        public string CreatedBy { get; set; }
    }
}
