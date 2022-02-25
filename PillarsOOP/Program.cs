using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PillarsOOP.Delegates;
using PillarsOOP.Exercise2;
using PillarsOOP.Exercise2.Interfaces;
using PillarsOOP.ExerciseRentalCars.Interfaces;
using PillarsOOP.ExerciseRentalCars.Models;
using PillarsOOP.Interfaces;
using PillarsOOP.Models;
using static PillarsOOP.Program;

namespace PillarsOOP
{
    class Program
    {

        static void Main(string[] args)
        {
            //var myType = Type.GetType("PillarsOOP.Models.CoffeeMaker");
            // DoSoemthing(myType);
            /*
            var person = new MyPerson();
            person.Name = "Jair";
            person.PrintName();
            person.Dispose();
            */
            //MyPrintName = DoName;

            var person = new MyPerson();
            person.OnNameChanged += MyText;
            person.Name = "asdasd";
            person.MyCountNameDelegate += Do;
            int count = person.MyCountNameDelegate("Jair");
            person.Name = "asdasdasd";
            Console.WriteLine($"count: {count}");
            var airplain = new Airplane();
            //Show2(person);
            //Show2(airplain);
            //Show2(new Bird());
            Show3<Airplane>(new Airplane());
            Show3(new Airplane());
            Show3(person);


        }

        public static void Show(object myObj)
        {
            if (myObj is Airplane)
            {
                var airplain = (Airplane)myObj;
                airplain.Dispose();
            }

            if (myObj is MyPerson)
            {
                var person = (MyPerson)myObj;
                person.Name = "sdasddasad";
                person.PrintName();
                person.Dispose();
            }
        }

        public static void Show2(object myObj)
        {
            /*
            if (myObj is IDisposable)
            {
                var obj = (IDisposable)myObj;
                obj.Dispose();
            }*/

            var obj = (IDisposable)myObj;
            obj.Dispose();
        }

        public static void Show3<T>(T obj) where T: IDisposable
        {
            obj.Dispose();
        }

        public static void Show4<T>(T coffe) where T : CoffeeMaker
        {
            //coffe.,.();
        }

        public static void MyText()
        {
            Console.WriteLine($"MyText executed");
        }

        public static int Do(string name)
        {
            return name.Length - 1;
        }

        public void DoName(string name)
        {
            Console.WriteLine(name);
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

    public class MyPerson : IDisposable
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnNameChanged?.Invoke();
            }
        }


        public event TextChanged OnNameChanged;

        public MyPrintName MyMethod;
        public CountMyName MyCountNameDelegate;


        private Stream _data;

        public MyPerson()
        {
            MyCountNameDelegate = Count;
            _data = new MemoryStream();
        }

        public void Dispose()
        {
            _data.Dispose();
            _data = null;
            Name = null;
            MyCountNameDelegate = null;
            //throw new NotImplementedException();
            Console.WriteLine($"IDisposable executed");
        }

        public void PrintName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        private int Count(string name)
        {
            Console.WriteLine($"Count {name.Length}");
            return name.Length;
        }
    }
}
