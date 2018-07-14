using Abstractions.CQRS;
using Airport.Contract.Command.AirCraft;
using AirPort.DataAccess;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class UpdateAirCraftCommandHandler : ICommandHandler<UpdateAirCraftCommand>
    {
        private readonly AirCraftRepository _airCraftRepository;

        public UpdateAirCraftCommandHandler(AirCraftRepository airCraftRepository)
        {
            _airCraftRepository = airCraftRepository;
        }

        public async Task ExecuteAsync(UpdateAirCraftCommand command)
        {
            var airCraft = await _airCraftRepository.GetById(command.AirCraftId);

            if (airCraft != null)
            {
                throw new Exception("AirCraft with same Id already exists");
            }

            airCraft.Name = command.Name ?? airCraft.Name;
            airCraft.TypeId = command.TypeId;
            airCraft.ReleaseDate = command.ReleaseDate;
            airCraft.TimeSpan = command.TimeSpan;

            await _airCraftRepository.Update(airCraft);
        }
    }
}
