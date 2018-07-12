using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Pilot
{
    class DeletePilotCommand : ICommand
    {
        public Guid PilotId { get; set; }
    }
}
