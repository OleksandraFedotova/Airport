using Abstractions.CQRS;
using System;

namespace Airport.Contract.Command.Stewardress
{
    class DeleteStewardressCommand : ICommand
    {
        public Guid StewardressId { get; set; }
    }
}
