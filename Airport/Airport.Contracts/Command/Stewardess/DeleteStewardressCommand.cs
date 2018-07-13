using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Stewardress
{
    public class DeleteStewardressCommand : ICommand
    {
        public Guid StewardressId { get; set; }
    }
}
