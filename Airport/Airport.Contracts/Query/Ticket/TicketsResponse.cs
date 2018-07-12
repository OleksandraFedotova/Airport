using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Ticket
{
    public class TicketsResponse: IResponse
    {
        public IEnumerable<Ticket> Tickets { get; set; }

        public class Ticket
        {
            public double Price { get; set; }
            public int FlightNumber { get; set; }
        }
    }
}
