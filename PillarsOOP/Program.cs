using System;
using System.Collections.Generic;
using PillarsOOP.Models;

namespace PillarsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMakers = new List<ICoffeeMaker>();

            var coffeeMaker = new CoffeeMaker();
            coffeeMaker.Coffee = 10;//g
            coffeeMaker.Water = 20;//ml
            coffeeMaker.MakeCoffee();
            Console.WriteLine($"Remaining Coffee: {coffeeMaker.Coffee}");
            Console.WriteLine($"Remaining Water: {coffeeMaker.Water}");

            //regular
            RegularCoffeeMaker regularCoffeeMaker = new RegularCoffeeMaker();
            regularCoffeeMaker.Coffee = 10;//g
            regularCoffeeMaker.Water = 20;//ml
            regularCoffeeMaker.MakeCoffee();

            //expresso
            ExpressoCoffeeMaker expressoCoffeeMaker = new ExpressoCoffeeMaker();
            expressoCoffeeMaker.Coffee = 10;//g
            expressoCoffeeMaker.Water = 20;//ml
            expressoCoffeeMaker.AddMilk(100);
            expressoCoffeeMaker.AddMilk("Lala");
            expressoCoffeeMaker.MakeCoffee();

            coffeeMakers.Add(regularCoffeeMaker);
            coffeeMakers.Add(expressoCoffeeMaker);

            ShowCoffeeMakers(coffeeMakers);
        }

        static void ShowCoffeeMakers(List<ICoffeeMaker> coffeeMakers)
        {
            Console.WriteLine("ShowCoffeeMakers =======>");

            foreach (var coffee in coffeeMakers)
            {
                coffee.MakeCoffee();
            }
        }
    }
}
