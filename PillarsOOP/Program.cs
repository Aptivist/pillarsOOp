using System;
using System.Collections.Generic;
using System.Linq;
using PillarsOOP.Exercise2;
using PillarsOOP.Exercise2.Interfaces;
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
            var myType = Type.GetType("PillarsOOP.Models.CoffeeMaker");
            DoSoemthing(myType);
        }

        public static void DoSoemthing(Type myType)
        {
            var methods = myType.GetMethods();
            var obj = Activator.CreateInstance(myType);
            //var method = myType.GetMethod("PrintName");
            foreach (var m in methods)
            {
                Console.WriteLine(m.Name);
                if (m.GetParameters() == null || !m.GetParameters().Any())
                {
                    m.Invoke(obj, null);
                }

            }
        }


    }



    public class MyPerson
    {
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
}
