using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    internal class Ex2
    {
        public static void Run()
        {
            Console.Write("Enter length ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height ");
            double width = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * (length + width);
            double area = length * width;

            Console.WriteLine("Perimeter " + perimeter);
            Console.WriteLine("Area " + area);
        }
    }
}
