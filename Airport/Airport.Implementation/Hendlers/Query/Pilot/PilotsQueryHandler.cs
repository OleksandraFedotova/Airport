using Abstractions.CQRS;
using Airport.Contract.Query.Pilot;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Pilot
{
    public class PilotsQueryHandler : IQueryHandler<PilotsQuery, PilotsResponse>
    {
        private readonly PilotRepository _pilotRepository;
        private readonly IMapper _mapper;

        public PilotsQueryHandler(PilotRepository pilotRepository, IMapper mapper)
        {
            _pilotRepository = pilotRepository;
            _mapper = mapper;
        }

        public async Task<PilotsResponse> ExecuteAsync(PilotsQuery request)
        {
            var pilots = _pilotRepository.GetAll();

            if (pilots == null)
            {
                throw new Exception("Pilots not found");
            }

            var mappedPilot = _mapper.Map<PilotsResponse>(pilots);

            return mappedPilot;
        }

        Task<PilotsResponse> IQueryHandler<PilotsQuery, PilotsResponse>.ExecuteAsync(PilotsQuery request)
        {
            throw new NotImplementedException();
        }
    }
}
