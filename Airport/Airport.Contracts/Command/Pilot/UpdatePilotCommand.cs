using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Pilot
{
    class UpdateStewardressCommand : ICommand
    {
        public Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName {get;set;}
        DateTime DateOfBirth { get; set; }
        int Experience { get; set; }
    }
}
