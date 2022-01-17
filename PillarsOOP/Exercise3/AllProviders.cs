using System;
using System.Collections.Generic;

namespace PillarsOOP.Exercise3
{
    public class AllProviders : IFlight
    {
        public IList<Flight> GetFlights()
        {
            var flights = new List<Flight>();
            var provider = new FlightProvider();

            var flightProviders = new List<IFlight>();
            flightProviders.Add(provider.GetInstance(Provider.Volaris));
            //flightProviders.Add(provider.GetInstance(Provider.Viva));
            flightProviders.Add(provider.GetInstance(Provider.Delta));

            foreach (var flightProvider in flightProviders)
            {
                var myFlights = flightProvider.GetFlights();
                flights.AddRange(myFlights);
            }

            return flights;
        }
    }
}
