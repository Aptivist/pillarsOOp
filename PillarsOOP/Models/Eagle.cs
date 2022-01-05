using System;
namespace PillarsOOP.Models
{
    public class Eagle : BirdFlyer
    {
        public Eagle()
        {
            Name = "Eagle";
        }

        public override void Fly()
        {
            Console.WriteLine($"Vuela como un {Name}...");
            MoveWings();
        }
    }
}
