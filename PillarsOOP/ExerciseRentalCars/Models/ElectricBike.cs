using System;
namespace PillarsOOP.ExerciseRentalCars.Models
{
    public class ElectricBike : Vehicle
    {
        public int Days { get; set; }

        public ElectricBike()
        {
            Name = "Electric Bike";
        }

        public override double GetTotal()
        {
            var price = 100;
            return Days * price;
        }

        public override bool IsValid()
        {
            var limit = 10;//days
            if (Days <= limit)
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
