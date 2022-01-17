using System;
using System.Collections.Generic;

namespace PillarsOOP.Exercise3
{
    public class VivaAerobus : IFlight
    {
        public IList<Flight> GetFlights()
        {
            //delta
            return new List<Flight>()
            {
                new Flight()
                {
                    Name = "VivaAerobus"
                }
            };
        }
    }
}
