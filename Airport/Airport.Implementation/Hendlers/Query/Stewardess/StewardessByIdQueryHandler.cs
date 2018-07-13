using Abstractions.CQRS;
using Airport.Contract.Query.Stewardess;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Stewardess
{
    public class StewardessByIdQueryHandler : IQueryHandler<StewardessByIdQuery, StewardessByIdResponse>
    {
        private readonly StewardessRepository _stewardessRepository;
        private readonly IMapper _mapper;

        public StewardessByIdQueryHandler(StewardessRepository stewardessRepository, IMapper mapper)
        {
            _stewardessRepository = stewardessRepository;
            _mapper = mapper;
        }

        public async Task<StewardessByIdResponse> ExecuteAsync(StewardessByIdQuery request)
        {
            var stewardess = await _stewardessRepository.GetById(request.StewardessId);

            if (stewardess == null)
            {
                throw new Exception("Stewardess not found");
            }

            var mappedStewardess = _mapper.Map<StewardessByIdResponse>(stewardess);

            return mappedStewardess;
        }
    }
}
