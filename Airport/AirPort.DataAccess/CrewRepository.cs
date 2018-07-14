using Airport.Domain.Entities;
using Airport.Domain.Repositiories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirPort.DataAccess
{
    public class CrewRepository : BaseRepository<Crew>, ICrewRepository
    {
        protected override void AddSeeds()
        {
            throw new NotImplementedException();
        }
    }
}
