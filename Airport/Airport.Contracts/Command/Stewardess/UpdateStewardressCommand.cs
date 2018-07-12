using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Stewardress
{
    class UpdateStewardressCommand : ICommand
    {
        string FirstName { get; set; }
        string LastName {get;set;}
        DateTime DateOfBirth { get; set; }
    }
}
