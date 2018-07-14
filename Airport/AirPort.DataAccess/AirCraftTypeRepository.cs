using Airport.Domain.Entities;
using Airport.Domain.Repositiories;
using System;

namespace AirPort.DataAccess
{
    public class AirCraftTypeRepository : BaseRepository<AirCraftType>, IAirCraftTypeRepository
    {
        protected override void AddSeeds()
        {
            throw new NotImplementedException();
        }
    }
}
