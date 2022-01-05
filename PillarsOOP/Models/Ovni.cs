using System;
using PillarsOOP.Interfaces;

namespace PillarsOOP.Models
{
    public class Ovni : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Vuela como un Ovni...");
        }
    }
}
