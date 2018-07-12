using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Stewardress
{
    class CreateStewardressCommand :ICommand
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
    }
}
