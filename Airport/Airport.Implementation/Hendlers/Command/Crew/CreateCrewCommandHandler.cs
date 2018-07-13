using Abstractions.CQRS;
using Airport.Contract.Command.Crew;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class CreateCrewCommandHandler : ICommandHandler<CreateCrewCommand>
    {
        private readonly CrewRepository _crewRepository;
        private readonly IMapper _mapper;

        public CreateCrewCommandHandler(CrewRepository crewRepository, IMapper mapper)
        {
            _crewRepository = crewRepository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(CreateCrewCommand command)
        {
            if (await _crewRepository.GetById(command.Id) != null)
            {
                throw new Exception("Crew with same Id already exists");
            }

            var crew = _mapper.Map<Airport.Domain.Entities.Crew>(command);

            await _crewRepository.Create(crew);
        }
    }
}
