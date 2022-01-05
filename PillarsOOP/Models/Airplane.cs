using System;
using PillarsOOP.Interfaces;

namespace PillarsOOP.Models
{
    public class Airplane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Vuela como un avion...");
        }
    }
}
