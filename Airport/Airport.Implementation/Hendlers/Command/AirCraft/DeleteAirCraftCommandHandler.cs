﻿using Abstractions.CQRS;
using Airport.Contract.Command.AirCraft;
using AirPort.DataAccess;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command.AirCraft
{
    public class DeleteAirCraftCommandHandler : ICommandHandler<DeleteAirCraftCommand>
    {
        private readonly AirCraftRepository _airCraftRepository;

        public DeleteAirCraftCommandHandler(AirCraftRepository airCraftRepository)
        {
            _airCraftRepository = airCraftRepository;
        }

        public async Task ExecuteAsync(DeleteAirCraftCommand command)
        {
            var airCraft = await _airCraftRepository.GetById(command.AirCraftId);

            if (airCraft != null)
            {
                throw new Exception("AirCraft with same Id already exists");
            }

            await _airCraftRepository.Delete(command.AirCraftId);
        }
    }
}