using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Ticket
{
    public class TicketByIdResponse: IResponse
    {
        public double Price { get; set; }
        public int FlightNumber { get; set; }
    }
}
