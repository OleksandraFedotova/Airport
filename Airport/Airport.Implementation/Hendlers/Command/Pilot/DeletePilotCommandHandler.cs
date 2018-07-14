using Abstractions.CQRS;
using Airport.Contract.Command.Pilot;
using AirPort.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command.Pilot
{
    public class DeletePilotCommandHandler : ICommandHandler<DeletePilotCommand>
    {
        private readonly PilotRepository _pilotRepository;

        public DeletePilotCommandHandler(PilotRepository pilotRepository)
        {
            _pilotRepository = pilotRepository;
        }

        public async Task ExecuteAsync(DeletePilotCommand command)
        {
            var pilot = await _pilotRepository.GetById(command.PilotId);

            if (pilot != null)
            {
                throw new Exception("Pilot with same Id already exists");
            }

            await _pilotRepository.Delete(pilot);
        }
    }
}
