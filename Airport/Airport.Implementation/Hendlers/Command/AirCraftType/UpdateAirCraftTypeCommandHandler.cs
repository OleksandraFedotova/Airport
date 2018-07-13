using Abstractions.CQRS;
using Airport.Contract.Command.AirCraftType;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class UpdateAirCraftTypeCommandHandler : ICommandHandler<UpdateAirCraftTypeCommand>
    {
        private readonly AirCraftTypeRepository _airCraftTypeRepository;

        public UpdateAirCraftTypeCommandHandler(AirCraftTypeRepository airCraftTypeRepository)
        {
            _airCraftTypeRepository = airCraftTypeRepository;
        }

        public async Task ExecuteAsync(UpdateAirCraftTypeCommand command)
        {
            var airCraftType = await _airCraftTypeRepository.GetById(command.AirCraftTypeId);

            if (airCraftType != null)
            {
                throw new Exception("AirCraftType with same Id already exists");
            }

            airCraftType.LoadCapacity = command.LoadCapacity;
            airCraftType.Model = command.Model ?? airCraftType.Model;
            airCraftType.Seats = command.Seats;

            await _airCraftTypeRepository.Update(command.AirCraftTypeId, airCraftType);
        }
    }
}
