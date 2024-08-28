using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    class Circle
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    internal class Ex17
    {
        public static void Run()
        {
            Circle[] circles = new Circle[]
            {
            new Circle { Radius = 2.0 },
            new Circle { Radius = 3.5 },
            new Circle { Radius = 4.0 }
            };
            double totalArea = 0;
            foreach (Circle circle in circles)
            {
                totalArea += circle.CalculateArea();
            }

            Console.WriteLine("Total area of all circles: " + totalArea);
        }
    }
}
