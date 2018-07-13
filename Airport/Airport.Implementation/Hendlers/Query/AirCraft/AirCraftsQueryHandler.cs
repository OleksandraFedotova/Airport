using Abstractions.CQRS;
using Airport.Contract.Query.AirCraft;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.AirCraft
{
    public class AirCraftsQueryHandler : IQueryHandler<AirCraftsQuery, AirCraftsResponse>
    {
        private readonly AirCraftRepository _airCraftRepository;
        private readonly IMapper _mapper;

        public AirCraftsQueryHandler(AirCraftRepository airCraftRepository, IMapper mapper)
        {
            _airCraftRepository = airCraftRepository;
            _mapper = mapper;
        }

        public async Task<AirCraftsResponse> ExecuteAsync(AirCraftsQuery request)
        {
            var airCrafts = _airCraftRepository.GetAll();

            if (airCrafts == null)
            {
                throw new Exception("AirCrafts not found");
            }

            var mappedAirCraft = _mapper.Map<AirCraftsResponse>(airCrafts);

            return mappedAirCraft;
        }
    }
}
