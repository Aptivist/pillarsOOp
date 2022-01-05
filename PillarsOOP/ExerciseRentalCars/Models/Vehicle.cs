using System;
using PillarsOOP.ExerciseRentalCars.Interfaces;

namespace PillarsOOP.ExerciseRentalCars.Models
{
    public abstract class Vehicle : IPrice, IValidate
    {
        public string Color { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }

        public abstract double GetTotal();
        public abstract bool IsValid();
    }
}
