using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Ticket
{
    public class TicketByIdQuery:IQuery<TicketByIdResponse>
    {
        public Guid TicketId { get; set; }
    }
}
