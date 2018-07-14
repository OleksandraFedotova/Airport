using Airport.Domain.Entities;
using Airport.Domain.Repositiories;
using System;

namespace AirPort.DataAccess
{
    public class FlightRepository : BaseRepository<Flight>, IFlightRepository
    {
        protected override void AddSeeds()
        {
            throw new NotImplementedException();
        }
    }
}
