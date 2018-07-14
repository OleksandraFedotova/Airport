using Airport.Domain.Entities;
using Airport.Domain.Repositiories;
using System;
using System.Collections.Generic;

namespace AirPort.DataAccess
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        protected override void AddSeeds()
        {

            
            _entities.Add(new KeyValuePair<Guid, Ticket>(
            Guid.NewGuid(),
            new Ticket
            {
                Id = Guid.NewGuid(),
                FlightNumber = 879809,
                Price = 500
            }));

            _entities.Add(new KeyValuePair<Guid, Ticket>(
            Guid.NewGuid(),
            new Ticket
            {
                Id = Guid.NewGuid(),
                FlightNumber = 3573732,
                Price = 450
            }));

        }
    }
}
