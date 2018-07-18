using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeATrip.Entities.Core;
using TakeATrip.Services.Models.TourModels;
using TakeATrip.Web.ViewModels.TourViewModels;

namespace TakeATrip.Web.MappingProfiles
{
    public class TourMappingProfile : Profile
    {
        public TourMappingProfile()
        {
            CreateMap<Tours, TourDetailViewModel>();
            CreateMap<CreateTourViewModel, CreatTourModel>();
        }

        public override string ProfileName
        {
            get { return this.GetType().FullName; }
        }
    }
}
