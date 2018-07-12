using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.Ticket
{
    class UpdateTicketCommand : ICommand
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
