using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.AirCraft
{
   public class AirCraftsResponse:IResponse 
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
