using Abstractions.CQRS;
using Airport.Contract.Command.Stewardress;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class UpdateStewsrdessCommandHandler : ICommandHandler<UpdateStewardressCommand>
    {
        private readonly StewardessRepository _stewardessRepository;

        public UpdateStewsrdessCommandHandler(StewardessRepository stewardessRepository)
        {
            _stewardessRepository = stewardessRepository;
        }

        public async Task ExecuteAsync(UpdateStewardressCommand command)
        {
            var stewardess = await _stewardessRepository.GetById(command.Id);

            if (stewardess != null)
            {
                throw new Exception("Stewardess with same Id already exists");
            }

            stewardess.FirstName = command.FirstName?? stewardess.FirstName;
            stewardess.LastName = command.LastName?? stewardess.LastName;
            stewardess.DateOfBirth = command.DateOfBirth;

            await _stewardessRepository.Update(command.Id, stewardess);
        }
    }
}
