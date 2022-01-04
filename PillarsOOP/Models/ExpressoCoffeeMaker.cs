using System;
namespace PillarsOOP.Models
{
    public class ExpressoCoffeeMaker : CoffeeMaker
    {
        public int Milk { get; private set; }

        public override void MakeCoffee()
        {
            var cup = Water + Coffee * Temperature + Milk;
            Water = Water - 5;
            Coffee = Coffee - 5;
            Milk = Milk - 1;
            Console.WriteLine($"Making Expresso Coffee :| {cup}");
        }

        public void AddMilk(int milk)
        {
            Milk = Milk + milk;
        }

        public void AddMilk(string milkname)
        {
            Console.WriteLine($"Milk Name {milkname}");
        }
    }
}
