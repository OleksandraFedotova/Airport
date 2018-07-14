using Abstractions.CQRS;
using Airport.Contract.Query.Crew;
using Airport.Contract.Query.Flight;
using Airport.Domain.Repositiories;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Crew
{
    public class FlightsQueryHandler : IQueryHandler<FlightsQuery, FlightsResponse>
    {
        private readonly IFlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public FlightsQueryHandler(IFlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public async Task<FlightsResponse> ExecuteAsync(FlightsQuery request)
        {
            var flights = _flightRepository.GetAll();

            if (flights == null)
            {
                throw new Exception("Flights not found");
            }

            var mappedCrew = _mapper.Map<FlightsResponse>(flights);

            return mappedCrew;
        }

        Task<FlightsResponse> IQueryHandler<FlightsQuery, FlightsResponse>.ExecuteAsync(FlightsQuery request)
        {
            throw new NotImplementedException();
        }
    }
}
