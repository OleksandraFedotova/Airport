using Abstractions.CQRS;
using Airport.Contract.Query.Crew;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Crew
{
    public class CrewByIdQueryHandler : IQueryHandler<CrewByIdQuery, CrewByIdResponse>
    {
        private readonly CrewRepository _crewRepository;
        private readonly IMapper _mapper;

        public CrewByIdQueryHandler(CrewRepository crewRepository, IMapper mapper)
        {
            _crewRepository = crewRepository;
            _mapper = mapper;
        }

        public async Task<CrewByIdResponse> ExecuteAsync(CrewByIdQuery request)
        {
            var crew = await _crewRepository.GetById(request.CrewId);

            if (crew == null)
            {
                throw new Exception("Idea not found");
            }

            var mappedCrew = _mapper.Map<CrewByIdResponse>(crew);

            return mappedCrew;
        }
    }
}
