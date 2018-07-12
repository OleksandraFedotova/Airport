using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.AirCraftType
{
    class DeleteAirCraftTypeCommand : ICommand
    {
        public Guid AirCraftId { get; set; }
    }
}
