using Abstractions.CQRS;
using Airport.Contract.Command.Departure;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class CreateDepartureCommandHandler : ICommandHandler<CreateDepartureCommand>
    {
        private readonly DepartureRepository _departureRepository;
        private readonly IMapper _mapper;

        public CreateDepartureCommandHandler(DepartureRepository departureRepository, IMapper mapper)
        {
            _departureRepository = departureRepository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(CreateDepartureCommand command)
        {
            if (await _departureRepository.GetById(command.Id) != null)
            {
                throw new Exception("Departure with same Id already exists");
            }

            var departure = _mapper.Map<Airport.Domain.Entities.Departure>(command);

            await _departureRepository.Create(departure);
        }
    }
}
