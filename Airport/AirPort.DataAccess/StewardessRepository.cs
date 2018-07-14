using Airport.Domain.Entities;
using Airport.Domain.Repositiories;
using System;

namespace AirPort.DataAccess
{
    public class StewardessRepository : BaseRepository<Stewardess>, IStewardessRepository
    {
        protected override void AddSeeds()
        {
           
        }
    }
}
