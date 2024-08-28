using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
    internal class Ex16
    {
        public static void Run()
        {
            Rectangle rect = new Rectangle { Width = 10.0, Height = 5.0 };
            double area = rect.CalculateArea();
            Console.WriteLine("Area of rectangle: " + area);
        }
    }
}
