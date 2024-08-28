using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
        }
    }

    internal class Ex12
    {
        public static void Run()
        {
            Car myCar = new Car("Toyota", "Corolla", 2022);
            myCar.DisplayInfo();
        }
    }
}
