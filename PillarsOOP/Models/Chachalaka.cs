using System;
namespace PillarsOOP.Models
{
    public class Chachalaka : BirdFlyer
    {
        public Chachalaka()
        {
            Name = "Chachalaka";
        }

        public override void Fly()
        {
            Console.WriteLine($"Vuela como un {Name}...");
            MoveWings();
        }
    }
}
