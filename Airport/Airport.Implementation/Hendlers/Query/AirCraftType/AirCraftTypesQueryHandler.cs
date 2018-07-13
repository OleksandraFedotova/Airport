using Abstractions.CQRS;
using Airport.Contract.Query.AirCraftType;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.AirCraftType
{
    public class AirCraftTypesQueryHandler : IQueryHandler<AirCraftTypesQuery, AirCraftTypesResponse>
    {
        private readonly AirCraftTypeRepository _crewRepository;
        private readonly IMapper _mapper;

        public AirCraftTypesQueryHandler(AirCraftTypeRepository crewRepository, IMapper mapper)
        {
            _crewRepository = crewRepository;
            _mapper = mapper;
        }

        public async Task<AirCraftTypesResponse> ExecuteAsync(AirCraftTypesQuery request)
        {
            var crews = _crewRepository.GetAll();

            if (crews == null)
            {
                throw new Exception("AirCraftTypes not found");
            }

            var mappedAirCraftType = _mapper.Map<AirCraftTypesResponse>(crews);

            return mappedAirCraftType;
        }
    }
}
