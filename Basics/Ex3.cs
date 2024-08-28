using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    internal class Ex3
    {
        public static void Run()
        {
            Console.Write("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is eve");
            }
            else
            {
                Console.WriteLine("The number is obb");
            }
        }
    }
}
