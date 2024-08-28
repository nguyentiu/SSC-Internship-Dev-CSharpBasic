using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    internal class Ex10
    {
        public static void Run()
        {
            Console.Write("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int i = 1;
            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
