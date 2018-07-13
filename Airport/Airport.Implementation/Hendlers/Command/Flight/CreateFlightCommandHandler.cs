using Abstractions.CQRS;
using Airport.Contract.Command.Flight;
using Airport.Contract.Command.Pilot;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class CreateFlightCommandHandler : ICommandHandler<CreateFlightCommand>
    {
        private readonly FlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public CreateFlightCommandHandler(FlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(CreateFlightCommand command)
        {
            if (await _flightRepository.GetById(command.Id) != null)
            {
                throw new Exception("Flight with same Id already exists");
            }

            var flight = _mapper.Map<Airport.Domain.Entities.Flight>(command);

            await _flightRepository.Create(flight);
        }
    }
}
