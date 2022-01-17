using System;
namespace PillarsOOP.Exercise3
{
    public interface IFlightFactory
    {
        IFlight GetInstance(Provider provider);
    }

    public enum Provider
    {
        All = 0,
        Viva = 1,
        Volaris = 2,
        Delta = 3
    }
}
