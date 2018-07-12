using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.AirCraftType
{
   public class AirCraftTypesResponse:IResponse 
    {
        public IEnumerable<AirCraftType> AirCraftTypes { get; set; }

        public class AirCraftType
        {
            public string Model { get; set; }
            public int Places { get; set; }
            public int LoadCapacity { get; set; }
        }
    }
}
