﻿using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.Departure
{
    class CreateDepartureCommand : ICommand
    {
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public Guid CrewId { get; set; }
        public Guid AirCraftId { get; set; }
    }

}
