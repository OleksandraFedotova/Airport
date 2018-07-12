using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Pilot
{
    class CreatePilotCommand :ICommand
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        int Experience { get; set; }
    }
}
