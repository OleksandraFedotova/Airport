using Abstractions.CQRS;
using Airport.Contract.Command.Stewardress;
using AirPort.DataAccess;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command.Pilot
{
    public class DeleteStewardressCommandHandler : ICommandHandler<DeleteStewardessCommand>
    {
        private readonly StewardessRepository _stewardessRepository;

        public DeleteStewardressCommandHandler(StewardessRepository stewardessRepository)
        {
            _stewardessRepository = stewardessRepository;
        }


        public async Task ExecuteAsync(DeleteStewardessCommand command)
        {
            var stewardess = await _stewardessRepository.GetById(command.StewardessId);

            if (stewardess != null)
            {
                throw new Exception("Stewardess with same Id already exists");
            }

            await _stewardessRepository.Delete(stewardess);
        }
    }
}
