using Abstractions.CQRS;
using Airport.Contract.Command.Crew;
using AirPort.DataAccess;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class UpdateCrewCommandHandler : ICommandHandler<UpdateCrewCommand>
    {
        private readonly CrewRepository _crewRepository;
        private readonly PilotRepository _pilotRepository;
        private readonly StewardessRepository _stewardessRepository;

        public UpdateCrewCommandHandler(CrewRepository crewRepository,PilotRepository pilotRepository, StewardessRepository stewardessRepository)
        {
            _crewRepository = crewRepository;
            _pilotRepository = pilotRepository;
            _stewardessRepository = stewardessRepository;
        }

        public async Task ExecuteAsync(UpdateCrewCommand command)
        {
            var crew = await _crewRepository.GetById(command.CrewId);

            if (crew != null)
            {
                throw new Exception("Crew with same Id already exists");
            }

           
            crew.Pilot = _pilotRepository.GetById(command.PilotId).Result;
            crew.Stewardesses = _stewardessRepository.GetAll().Where(y => command.StewardressesId.Contains(y.Id));

            await _crewRepository.Update(crew);
        }
    }
}
