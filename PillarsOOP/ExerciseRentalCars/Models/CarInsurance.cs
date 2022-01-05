using System;
using PillarsOOP.ExerciseRentalCars.Interfaces;

namespace PillarsOOP.ExerciseRentalCars.Models
{
    public class CarInsurance : IPrice
    {
        public string Name { get; set; }

        public double GetTotal()
        {
            return 100.30;
        }
    }
}
