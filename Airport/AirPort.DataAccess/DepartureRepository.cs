using Airport.Domain.Entities;
using Airport.Domain.Repositiories;
using System;

namespace AirPort.DataAccess
{
    public class DepartureRepository : BaseRepository<Departure>, IDepartureRepository
    {
        protected override void AddSeeds()
        {
            throw new NotImplementedException();
        }
    }
}
