using Abstractions.CQRS;
using Airport.Contract.Command.Flight;
using Airport.Contract.Command.Pilot;
using AirPort.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command.Pilot
{
    public class DeleteFlightCommandHandler : ICommandHandler<DeleteFlightCommand>
    {
        private readonly FlightRepository _flightRepository;

        public DeleteFlightCommandHandler(FlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public async Task ExecuteAsync(DeleteFlightCommand command)
        {
            var flight = await _flightRepository.GetById(command.FlightId);

            if (flight != null)
            {
                throw new Exception("Flight with same Id already exists");
            }

            await _flightRepository.Delete(flight);
        }
    }
}
