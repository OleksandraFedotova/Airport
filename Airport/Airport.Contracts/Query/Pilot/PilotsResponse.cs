using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Pilot
{
    class PilotsResponse : IResponse
    {
        public IEnumerable<Pilot> Pilots { get; set; }

        public class Pilot
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            DateTime DateOfBirth { get; set; }
            int Experience { get; set; }
        }
    }
}
