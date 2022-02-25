using System;
using PillarsOOP.Interfaces;

namespace PillarsOOP.Models
{
    public class Airplane : IFly, IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
            Console.WriteLine("IDisposable como un avion...");

        }

        public void Fly()
        {
            Console.WriteLine("Vuela como un avion...");
        }
    }
}
