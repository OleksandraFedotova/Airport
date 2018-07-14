using Abstractions.CQRS;
using Airport.Contract.Command.AirCraftType;
using AirPort.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command.AirCraftType
{
    public class DeleteAirCraftTypeCommandHandler : ICommandHandler<DeleteAirCraftTypeCommand>
    {
        private readonly AirCraftTypeRepository _airCraftTypeRepository;

        public DeleteAirCraftTypeCommandHandler(AirCraftTypeRepository airCraftTypeRepository)
        {
            _airCraftTypeRepository = airCraftTypeRepository;
        }

        public async Task ExecuteAsync(DeleteAirCraftTypeCommand command)
        {
            var airCraftType = await _airCraftTypeRepository.GetById(command.AirCraftTypeId);

            if (airCraftType != null)
            {
                throw new Exception("AirCraftType with same Id already exists");
            }

            await _airCraftTypeRepository.Delete(airCraftType);
        }
    }
}
