using System;
using System.Collections.Generic;
using PillarsOOP.ExerciseRentalCars.Interfaces;
using PillarsOOP.ExerciseRentalCars.Models;
using PillarsOOP.Interfaces;
using PillarsOOP.Models;

namespace PillarsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<IPrice>();
            //ask for insurance
            var insurance = new CarInsurance();
            insurance.Name = "insurance";
            products.Add(insurance);

            //ask for vehicle
            var electricBike = new ElectricBike();
            electricBike.Days = 3;

            if (electricBike.IsValid())
            {
                //add
                products.Add(electricBike);
            }
            else
            {
                Console.WriteLine("it is not valid electric bike");
                return;
            }

            var moto = new MotorCycle();
            moto.Days = 4;

            if (moto.IsValid())
            {
                //add
                products.Add(moto);
            }
            else
            {
                Console.WriteLine("it is not valid moto");
            }

            var car = new Car();
            car.Weeks = 1;
            //is valid?
            if (car.IsValid())
            {
                //add
                products.Add(car);
            }
            else
            {
                Console.WriteLine("it is not valid Car");
            }

            double total = 0;

            foreach (var product in products)
            {
                total = total + product.GetTotal();

                //print products

                if (product is Vehicle)
                {
                    var vehicle = product as Vehicle;
                    Console.WriteLine($"Name : {vehicle.Name}");
                }
                else if (product is CarInsurance)
                {
                    var carInsurance = product as CarInsurance;
                    Console.WriteLine($"Name : ${carInsurance.Name}");
                }
            }

            Console.WriteLine($"Total price: ${total}");
        }
    }
}
