using System;
namespace PillarsOOP.Models
{
    public class CoffeeMaker : ICoffeeMaker
    {
        private bool _isWorking;
        protected const int Temperature = 100;

        public int Water { get; set; }
        public int Coffee { get; set; }

        public virtual void MakeCoffee()
        {
            if (!_isWorking)
            {
                _isWorking = true;
                //to something
                var cup = Water * Coffee + Temperature;
                Water = Water - 10;
                Coffee = Coffee - 2;
                Console.WriteLine($"Making CoffeeMaker Coffee :) {cup}");
                _isWorking = false;
            }
        }
    }
}
