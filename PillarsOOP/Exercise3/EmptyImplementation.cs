using System;
using System.Collections.Generic;

namespace PillarsOOP.Exercise3
{
    public class EmptyImplementation : IFlight
    {
        public IList<Flight> GetFlights()
        {
            return new List<Flight>();
        }
    }
}
