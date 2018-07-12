﻿using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.Flight
{
    class DeleteFlightCommand : ICommand
    {
        public Guid FlightId { get; set; }
    }
}
