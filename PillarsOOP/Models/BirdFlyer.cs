using System;
using PillarsOOP.Interfaces;

namespace PillarsOOP.Models
{
    public abstract class BirdFlyer : Bird, IFly
    {
        public abstract void Fly();

        public virtual void MoveWings()
        {
            Console.WriteLine("Moving Wings....");
        }
    }
}
