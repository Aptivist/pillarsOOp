using System;
using System.Collections.Generic;

namespace PillarsOOP.Exercise3
{
    public class FlightProvider : IFlightFactory
    {
        public IFlight GetInstance(Provider provider)
        {
            switch (provider)
            {
                case Provider.Delta:
                    return new Delta();
                case Provider.Viva:
                    return new VivaAerobus();
                    //v1, v3
                case Provider.Volaris:
                    return new Volaris();
                case Provider.All:
                    return new AllProviders();
                default:
                    return new EmptyImplementation();
            }
        }
    }
}
