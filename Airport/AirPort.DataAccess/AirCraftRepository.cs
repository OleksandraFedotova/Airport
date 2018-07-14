using Airport.Domain.Entities;
using Airport.Domain.Repositiories;

namespace AirPort.DataAccess
{
    public class AirCraftRepository : BaseRepository<AirCraft>, IAirCraftRepository
    {
        protected override void AddSeeds()
        {

        }
    }
}
