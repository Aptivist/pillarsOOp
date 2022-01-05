using System;
using PillarsOOP.Interfaces;

namespace PillarsOOP.Models
{
    public class Bird
    {
        public string Name { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine("Camina como un pajaro...");
        }
    }
}
