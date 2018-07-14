using Abstractions.CQRS;
using Airport.Contract.Command.Departure;
using Airport.Domain.Repositiories;
using AirPort.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command.Departure
{
    public class DeleteDepartureCommandHandler : ICommandHandler<DeleteDepartureCommand>
    {
        private readonly IDepartureRepository _departureRepository;

        public DeleteDepartureCommandHandler(IDepartureRepository departureRepository)
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

            await _departureRepository.Delete(departure);
        }
    }
}
