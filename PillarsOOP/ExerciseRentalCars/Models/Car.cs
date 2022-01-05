using System;
namespace PillarsOOP.ExerciseRentalCars.Models
{
    public class Car : Vehicle
    {
        public int Weeks { get; set; }

        public Car()
        {
            Name = "Car";
        }

        public override double GetTotal()
        {
            var price = 200;
            return price * Weeks * 7;
        }

        public override bool IsValid()
        {
            var limit = 2;//weeks
            if (Weeks <= limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
