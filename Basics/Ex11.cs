using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    internal class Ex11
    {
        public static void Run()
        {
            int number;
            do
            {
                Console.Write("Enter a positive integer: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number <= 0);

            Console.WriteLine("You entered: " + number);
        }
    }
}
