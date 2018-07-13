using Abstractions.CQRS;
using Airport.Contract.Query.Crew;
using Airport.Contract.Query.Flight;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Crew
{
    public class FlightsQueryHandler : IQueryHandler<FlightsQuery, FlightsResponse>
    {
        private readonly CrewRepository _crewRepository;
        private readonly IMapper _mapper;

        public FlightsQueryHandler(CrewRepository crewRepository, IMapper mapper)
        {
            _crewRepository = crewRepository;
            _mapper = mapper;
        }

        public async Task<FlightsResponse> ExecuteAsync(FlightsQuery request)
        {
            var flights = _crewRepository.GetAll();

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
