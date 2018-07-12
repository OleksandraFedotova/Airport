using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Departure
{
    public class DepartureByIdQuery:IQuery<DepartureByIdResponse>
    {
        public Guid DepartureId { get; set; }
    }
}
