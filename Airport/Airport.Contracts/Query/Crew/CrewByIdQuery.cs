using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Crew
{
   public  class CrewByIdQuery:IQuery<CrewByIdResponse>
    {
        public Guid CrewId { get; set; }
    }
}
