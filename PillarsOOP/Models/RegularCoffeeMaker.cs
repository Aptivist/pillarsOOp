using System;
namespace PillarsOOP.Models
{
    public class RegularCoffeeMaker : CoffeeMaker
    {
        public override void MakeCoffee()
        {
            var cup = Water + Coffee + Temperature;
            Water = Water - 1;
            Coffee = Coffee - 1;
            Console.WriteLine($"Making Regular Coffee :) {cup}");
        }

    }
}
