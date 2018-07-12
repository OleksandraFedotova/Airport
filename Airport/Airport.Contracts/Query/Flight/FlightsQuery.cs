using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Flight
{
    public class FlightsQuery:IQuery<FlightsResponse>
    {
    }
}
