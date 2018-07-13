using Abstractions.CQRS;
using Airport.Contract.Command.Departure;
using AirPort.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command.Departure
{
    public class DeleteDepartureCommandHandler : ICommandHandler<DeleteDepartureCommand>
    {
        private readonly DepartureRepository _departureRepository;

        public DeleteDepartureCommandHandler(DepartureRepository departureRepository)
        {
            _departureRepository = departureRepository;
        }

        public async Task ExecuteAsync(DeleteDepartureCommand command)
        {
            var departure = await _departureRepository.GetById(command.DepartureId);

            if (departure != null)
            {
                throw new Exception("Departure with same Id already exists");
            }

            await _departureRepository.Delete(command.DepartureId);
        }
    }
}
