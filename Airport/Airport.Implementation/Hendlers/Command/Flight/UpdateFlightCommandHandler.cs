using Abstractions.CQRS;
using Airport.Contract.Command.Flight;
using Airport.Contract.Command.Pilot;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class UpdateFlightCommandHandler : ICommandHandler<UpdateFlightCommand>
    {
        private readonly FlightRepository _flightRepository;
        private readonly TicketRepository _ticketRepository;

        public UpdateFlightCommandHandler(FlightRepository flightRepository,TicketRepository ticketRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _ticketRepository = ticketRepository;
        }


        public async Task ExecuteAsync(UpdateFlightCommand command)
        {
            var flight = await _flightRepository.GetById(command.FlightId);

            if (flight != null)
            {
                throw new Exception("Flight with same Id already exists");
            }

            flight.DeparturePoint = command.DeparturePoint ?? flight.DeparturePoint;
            flight.DepartureTime = command.DepartureTime;
            flight.Destination = command.Destination ?? flight.Destination;
            flight.TimeOfArrival = command.TimeOfArrival;
            flight.Number = command.Number;
            flight.Tickets = null;
            flight.Tickets=_ticketRepository.GetAll().Where(y=>command.TicketsId.Contains(y.Id));

            await _flightRepository.Update(command.FlightId, flight);
        }
    }
}
