using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Pilot
{
    public class PilotByIdQuery: IQuery<PilotByIdResponse>
    {
        public Guid PilotId { get; set; }
    }
}
