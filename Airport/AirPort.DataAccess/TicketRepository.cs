using Airport.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AirPort.DataAccess
{
    public class TicketRepository : BaseRepository<Ticket>
    {
        protected override void AddSeeds()
        {

            
            _entities.Add(new KeyValuePair<Guid, Ticket>(
            new Guid(),
            new Ticket
            {
                Id = new Guid(),
                FlightNumber = 879809,
                Price = 500
            }));

            _entities.Add(new KeyValuePair<Guid, Ticket>(
            new Guid(),
            new Ticket
            {
                Id = new Guid(),
                FlightNumber = 3573732,
                Price = 450
            }));

        }
    }
}
