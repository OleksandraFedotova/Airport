using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.AirCraftType
{
    class UpdateAirCraftTypeCommandv : ICommand
    {
        public Guid AirCraftType { get; set; }
        public string Model { get; set; }
        public int Places { get; set; }
        public int LoadCapacity { get; set; }
    }
}
