using Abstractions.CQRS;
using Airport.Contract.Command.Departure;
using AirPort.DataAccess;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class UpdateDepartureCommandHandler : ICommandHandler<UpdateDepartureCommand>
    {
        private readonly DepartureRepository _departureRepository;

        public UpdateDepartureCommandHandler(DepartureRepository departureRepository)
        {
            _departureRepository = departureRepository;
        }

        public async Task ExecuteAsync(UpdateDepartureCommand command)
        {
            var departure = await _departureRepository.GetById(command.DepartureId);

            if (departure != null)
            {
                throw new Exception("Departure with same Id already exists");
            }

            departure.AirCraftId = command.AirCraftId;
            departure.CrewId = command.CrewId;
            departure.DepartureDate = command.DepartureDate;
            departure.FlightNumber = command.FlightNumber;

            await _departureRepository.Update(departure);
        }
    }
}
