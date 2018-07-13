using Abstractions.CQRS;
using Airport.Contract.Query.Crew;
using Airport.Contract.Query.Departure;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Crew
{
    public class DeparturesQueryHandler : IQueryHandler<DeparturesQuery, DeparturesResponse>
    {
        private readonly CrewRepository _crewRepository;
        private readonly IMapper _mapper;

        public DeparturesQueryHandler(CrewRepository crewRepository, IMapper mapper)
        {
            _crewRepository = crewRepository;
            _mapper = mapper;
        }

        public async Task<DeparturesResponse> ExecuteAsync(DeparturesQuery request)
        {
            var departures = _crewRepository.GetAll();

            if (departures == null)
            {
                throw new Exception("Departures not found");
            }

            var mappedCrew = _mapper.Map<DeparturesResponse>(departures);

            return mappedCrew;
        }

        Task<DeparturesResponse> IQueryHandler<DeparturesQuery, DeparturesResponse>.ExecuteAsync(DeparturesQuery request)
        {
            throw new NotImplementedException();
        }
    }
}
