using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Stewardress
{
    public class CreateStewardressCommand : ICommand
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
