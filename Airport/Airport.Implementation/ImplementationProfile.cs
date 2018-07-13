using Airport.Contract.Query.Pilot;
using Airport.Contract.Query.Stewardess;
using AutoMapper;

namespace Airport.Implementation
{
    public class ImplementationProfile : Profile
    {
        public ImplementationProfile()
        {
            CreateMap<Airport.Domain.Entities.Pilot, PilotByIdResponse>();
            CreateMap< Airport.Domain.Entities.Stewardess, StewardessByIdResponse >();
           
        }
    }
}
