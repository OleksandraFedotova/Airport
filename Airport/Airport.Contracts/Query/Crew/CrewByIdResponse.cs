using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Query.Crew
{
  public  class CrewByIdResponse:IResponse 
    {
        public IEnumerable<Stewardress> Stewardresses { get; set; }
        public Pilot CrewPilot { get; set; }
        public class Pilot
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int Experience { get; set; }
        }
        public class Stewardress
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
        }
    }
}
