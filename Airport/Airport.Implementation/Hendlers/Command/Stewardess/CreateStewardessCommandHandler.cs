using Abstractions.CQRS;
using Airport.Contract.Command.Stewardress;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class CreateStewardessCommandHandler : ICommandHandler<CreateStewardressCommand>
    {
        private readonly StewardessRepository _stewardessRepository;
        private readonly IMapper _mapper;

        public CreateStewardessCommandHandler(StewardessRepository stewardessRepository, IMapper mapper)
        {
            _stewardessRepository = stewardessRepository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(CreateStewardressCommand command)
        {
            if (await _stewardessRepository.GetById(command.Id) != null)
            {
                throw new Exception("Stewardess with same Id already exists");
            }

            var stewardess = _mapper.Map<Airport.Domain.Entities.Stewardess>(command);

            await _stewardessRepository.Create(stewardess);
        }
    }
}
