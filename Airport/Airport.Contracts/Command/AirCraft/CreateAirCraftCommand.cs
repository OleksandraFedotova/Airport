using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.AirCraft
{
    class CreateAirCraftCommand : ICommand
    {
        public string Name { get; set; }
        public Guid TypeId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTim TimeSpan { get; set; }

    }
}
