using System;
using Airport.Domain.Repositiories;

namespace Airport.Domain.Entities
{
    public class AirCraftType : IEntity
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public int Places { get; set; }
        public int LoadCapacity { get; set; }
    }
}
