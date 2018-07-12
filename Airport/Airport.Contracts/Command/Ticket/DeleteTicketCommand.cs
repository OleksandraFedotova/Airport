using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.Ticket
{
    class DeleteTicketCommand : ICommand
    {
        public Guid TicketId { get; set; }
    }
}
