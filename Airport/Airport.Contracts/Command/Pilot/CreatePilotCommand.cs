using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Pilot
{
    public class CreatePilotCommand :ICommand
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Experience { get; set; }
    }
}
