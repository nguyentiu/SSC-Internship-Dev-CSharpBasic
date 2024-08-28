using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    internal class Ex4
    {
        public static void Run()
        {
            int[] number = { 1, 2, 3, 4, 5, 6 };
            int sum = 0;
            foreach (int num in number)
            {
                sum+= num;
            }

            double average = (double)sum/number.Length;

            Console.WriteLine(sum);
            Console.WriteLine(average);
        }
    }
}
