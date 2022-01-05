using System;
namespace PillarsOOP.ExerciseRentalCars.Models
{
    public class MotorCycle : Vehicle
    {
        public int Days { get; set; }

        public MotorCycle()
        {
            Name = "Motor Cycle";
        }

        public override double GetTotal()
        {
            var price = 5;

            return Days * price;
        }

        public override bool IsValid()
        {
            var limit = 5;//days
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
