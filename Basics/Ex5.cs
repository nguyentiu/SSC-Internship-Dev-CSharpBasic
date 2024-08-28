using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Days { Monday, Tuesday, Wednesday, Thursday, Friday }

namespace C_Exercises.Basics
{
    internal class Ex5
    {
        public static void Run()
        {
            Console.Write("Enter a number (0-6): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            if ( dayNumber > 0 && dayNumber <=6) { 
                Days days = (Days)dayNumber;
                Console.WriteLine("Day "+ days);
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}
