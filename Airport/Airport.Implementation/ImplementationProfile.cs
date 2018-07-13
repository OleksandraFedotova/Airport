using Airport.Contract.Query.AirCraft;
using Airport.Contract.Query.AirCraftType;
using Airport.Contract.Query.Departure;
using Airport.Contract.Query.Pilot;
using Airport.Contract.Query.Stewardess;
using Airport.Contract.Query.Ticket;
using AutoMapper;

namespace Airport.Implementation
{
    public class ImplementationProfile : Profile
    {
        public ImplementationProfile()
        {
            CreateMap<Airport.Domain.Entities.Pilot, PilotByIdResponse>();
            CreateMap<Airport.Domain.Entities.Stewardess, StewardessByIdResponse>();
            CreateMap<Airport.Domain.Entities.AirCraft, AirCraftByIdResponse>();
            CreateMap<Airport.Domain.Entities.AirCraftType, AirCraftTypeByIdResponse>();
            CreateMap<Airport.Domain.Entities.Departure, DepartureByIdResponse>();
            CreateMap<Airport.Domain.Entities.Ticket, TicketByIdResponse>();
        }
    }
}
