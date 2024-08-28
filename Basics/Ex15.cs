using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Display()
        {
            Console.WriteLine("Point coordinates: (" + X + ", " + Y + ")");
        }
    }
    internal class Ex15
    {
        public static void Run()
        {
            Point p = new Point { X = 10, Y = 20 };
            p.Display();
        }
    }
}
