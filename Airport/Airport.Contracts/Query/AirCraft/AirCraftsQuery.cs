using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.AirCraft
{
    public class AirCraftsQuery:IQuery<AirCraftsResponse>
    {
        public IEnumerable<AirCraft> AirCrafts { get; set; }

        public class AirCraft
        {
            public string Name { get; set; }
            public Guid TypeId { get; set; }
            public DateTime ReleaseDate { get; set; }
            public DateTime TimeSpan { get; set; }
        }
    }
}
