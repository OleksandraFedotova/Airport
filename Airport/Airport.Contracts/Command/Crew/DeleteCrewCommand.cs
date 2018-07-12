using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Crew
{
    class DeleteCrewCommand:ICommand
    {
        public Guid CrewId { get; set; }
    }
}
